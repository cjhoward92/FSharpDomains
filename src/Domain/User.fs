namespace Domain

module User =
    type User = {
        FirstName: string;
        LastName: string;
        Address: string;
    }

    type ValidUser = ValidUser of User | InvalidUser of string * string

    let validateLength (value: string) =
        match value with
        | null -> false
        | _ -> value.Length > 0

    // We can probably create a computation expression for validation
    let createUser fname lname addr =
        let validationStatus = (validateLength fname, validateLength lname, validateLength addr)
        match validationStatus with
        | (false, _, _) -> InvalidUser ("FirstName", "First name cannot be blank")
        | (_, false, _) -> InvalidUser ("LastName", "Last name cannot be blank")
        | (_, _, false) -> InvalidUser ("Address", "Address cannot be blank")
        | _ -> ValidUser { FirstName = fname; LastName = lname; Address = addr }