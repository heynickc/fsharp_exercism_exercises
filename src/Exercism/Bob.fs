namespace Exercism

module Bob = 

    open System.Text.RegularExpressions

    let (|IsMatch|_|) (re:string) (inp:string) =
        if Regex(re).IsMatch(inp) then Some() else None

    let isAllCaps s = 
        String.exists System.Char.IsLetter s 
        && not (String.exists System.Char.IsLower s)

    let hey words = 
        match words with
        | words when isAllCaps words -> "Whoa, chill out!"
        | IsMatch "[?]$" -> "Sure."
        | IsMatch "^\s*$" -> "Fine. Be that way!"
        | _ -> "Whatever."
