namespace Exercism

module Trinary = 
    
    let (|IsAllNumbers|_|)  s =
        if String.forall System.Char.IsNumber s
        then Some() else None

    let (|IsAllTrinaryDigits|_|) ia =
        let allBinary = 
            ia
            |> Array.choose id
            |> Array.forall (fun j -> j < 3)
        if allBinary then Some() else None

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
    
    let isIntArrayAllBinary ia =
        match ia with
        | IsAllTrinaryDigits -> ia
        | _ -> [| Some(0) |]

    let intToBaseThree i power =
        match i with
        | Some j -> j * (pown 3 power)
        | None -> 0

    let intArrayToBaseThree intArray =
        let intArrayLen = intArray |> Array.length
        let exponents = [| (intArrayLen - 1) .. -1 .. 0 |]
        intArray 
        |> Array.mapi (fun index i -> intToBaseThree i exponents.[index]) 
        |> Array.reduce (+)
    
    let toDecimal s =
        s 
        |> stringToIntArray
        |> isIntArrayAllBinary
        |> intArrayToBaseThree