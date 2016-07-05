namespace Exercism

module Hamming = 
    let compareChars charOne charTwo = 
        match charOne = charTwo with
        | true -> 0
        | false -> 1
    
    let distance (strOne : string) (strTwo : string) len = 
        len
        |> Array.zeroCreate
        |> Array.mapi (fun i _ -> compareChars (strOne.Chars(i)) (strTwo.Chars(i)))
        |> Array.reduce (+)
    
    let isComputable strOne strTwo = 
        let strOneLen = strOne |> String.length
        let strTwoLen = strTwo |> String.length
        match strOneLen > 0 && strTwoLen > 0 && strOneLen = strTwoLen with
        | true -> Some(strOneLen)
        | false -> None
    
    let compute strOne strTwo = 
        match isComputable strOne strTwo with
        | Some(x) -> distance strOne strTwo x
        | None -> 0
