module getip

let addExclamation string =
    string + "!"

let rec map func array =
    match array with
        | [] -> []
        | golova :: hvost -> func golova :: map func hvost


[<EntryPoint>]
let main argv =
    argv
        |> map addExclamation
        |> printfn "%A"
    // printfn "%A" (Array.map addExclamation argv)
    0 // return an integer exit code

// let (|>) value func = func value
