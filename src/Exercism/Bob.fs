namespace Exercism

open System.Text.RegularExpressions

module Bob = 

    let (|IsMatch|_|) (re : string) (inp : string) =
        if Regex(re).IsMatch(inp)  then Some() else None

    let isAllCaps s =
        match s with
        | s when String.exists (fun c -> System.Char.IsLower(c)) s -> false
        | _ -> true
      
    let hasAnyLetters s =
        match s with
        | s when String.exists (fun c -> System.Char.IsLetter(c)) s -> true
        | _ -> false

    let hey words = 
        match words with
        | words when 
            hasAnyLetters words 
            && isAllCaps words -> "Whoa, chill out!"
        | IsMatch "[?]$" -> "Sure."
        | IsMatch "^\s*$" -> "Fine. Be that way!"
        | _ -> "Whatever."
