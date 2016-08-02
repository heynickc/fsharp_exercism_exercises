namespace Exercism

module PigLatin = 
    let vowels = [| ("a", 1); ("e", 1); ("i", 1); ("o", 1); ("u", 1); ("yt", 2); ("xr", 2) |]
    let extraConsonants = [| ("ch", 2); ("qu", 2); ("th", 2); ("thr", 3); ("sch", 3); |]
    let allConsonants = 
        [| 'a' .. 'z' |] 
        |> Array.map (fun x -> x.ToString()) 
        |> Array.except (vowels |> Array.map (fun (x, _) -> x))
        |> Array.append (extraConsonants |> Array.map (fun (x, _) -> x))

    let (|StartsWithVowel|_|) (w : string) = 
        if vowels |> Array.exists (fun (x, y) -> w.StartsWith(x)) then Some(w)
        else None
    
    let (|StartsWithExtraConsonant|_|) (w: string)=
        if extraConsonants |> Array.exists (fun (x, y) -> w.StartsWith(x)) then Some((w))
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
