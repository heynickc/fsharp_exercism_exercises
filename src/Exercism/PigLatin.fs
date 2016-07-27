namespace Exercism

module PigLatin = 
    let vowels = [| "a"; "e"; "i"; "o"; "u"; "yt"; "xr" |]
    let extraConsonants = [| "ch"; "qu"; "th"; "thr"; "sch"; |]
    type CharacterMatch = | CharacterMatch of string * int
   
    let (|StartsWithVowel|_|) (w : string) = 
        if vowels |> Array.exists (fun x -> w.StartsWith(x)) then Some(w)
        else None
    
    let (|StartsWithExtraConsonant|_|) (w: string)=
        if extraConsonants |> Array.exists (fun x -> w.StartsWith(x)) then Some((w))
        else None

    let (|StartsWithConsonant|_|) (w : string) = 
        match w with
        | StartsWithVowel w -> None
        | StartsWithExtraConsonant w -> Some(w) 
        | _ -> Some(w)
    
    let translate (w : string) = 
        match w with
        | StartsWithVowel w -> w + "ay"
        | StartsWithConsonant w -> w.Substring(1, w.Length - 1) + w.[0].ToString() + "ay"
        | _ -> "nope"
