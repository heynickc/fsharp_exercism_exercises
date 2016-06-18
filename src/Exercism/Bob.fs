namespace Exercism

open System.Text.RegularExpressions

module Bob = 

    let (|IsMatch|_|) (re : string) (inp : string) =
        if Regex(re).IsMatch(inp)  then Some() else None

    let isAllCaps (s:string) =
        s.Split ' '
        |> Array.exists(fun x -> Regex(x).IsMatch("[a-z]"))
        

    let hey words = 
        match words with
        | IsMatch "[!$]" -> "Whoa, chill out!"
        |  -> "Whoa, chill out!"
        | IsMatch "[?$]" -> "Sure."
        | _ -> "Whatever."
