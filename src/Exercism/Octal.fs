namespace Exercism

module Octal = 

    let (|IsAllNumbers|_|)  s =
        if String.forall System.Char.IsNumber s
        then Some() else None

    let (|IsAllOctalDigits|_|) ia = 
        let allOctal = 
            ia
            |> Array.choose id
            |> Array.forall (fun j -> j < 8)
        if allOctal then Some()
        else None

    let parseCharToInt c = 
        match System.Int32.TryParse(System.Char.ToString(c)) with
        | true, value -> Some value
        | _ -> None      

    let createIntArray s =
        let sLen = s |> String.length
        Array.init sLen (fun n -> parseCharToInt (s.Chars(n)))

    let stringToIntArray s = 
        match s with
        | IsAllNumbers -> createIntArray s
        | _ -> [| Some(0) |]
    
    let isIntArrayAllOctal ia = 
        match ia with
        | IsAllOctalDigits -> ia
        | _ -> [| Some(0) |]
    
    let intToOctal i power =
        match i with
        | Some j -> j * (pown 8 power)
        | None -> 0

    let intArrayToOctal intArray = 
        let intArrayLen = intArray |> Array.length
        let exponents = [| (intArrayLen - 1) .. -1 .. 0 |]
        intArray
        |> Array.mapi (fun index i -> intToOctal i exponents.[index])
        |> Array.reduce (+)

    let toDecimal s = 
        s
        |> stringToIntArray
        |> isIntArrayAllOctal
        |> intArrayToOctal

