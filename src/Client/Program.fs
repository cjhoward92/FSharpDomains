// Learn more about F# at http://fsharp.org

open System
open Domain.User

[<EntryPoint>]
let main argv =
    let fname = "Carson"
    let lname = "Howard"
    let addr = "123 w oak"

    match createUser fname lname addr with
    | InvalidUser (prop, err) -> printfn "Error on %s: %s" prop err
    | ValidUser user -> printfn "%A" user

    0 // return an integer exit code
