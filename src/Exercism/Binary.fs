﻿namespace Exercism

module Binary = 

    let (|IsAllNumbers|_|)  s =
        if String.forall System.Char.IsNumber s
        then Some() else None

    let (|IsAllBinaryDigits|_|) ia =
        let allBinary = 
            ia
            |> Array.choose id
            |> Array.forall (fun j -> j < 2)
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
        | IsAllBinaryDigits -> ia
        | _ -> [| Some(0) |]

    let intToBaseTwo i pos = 
        match i with
        | Some j -> j * (pown 2 pos)
        | None -> 0
    
    let intArrayToBaseTwo intArray = 
        let intArrayLen = intArray |> Array.length
        let exponents = [| (intArrayLen - 1) .. -1 .. 0 |]
        intArray 
        |> Array.mapi (fun index i -> intToBaseTwo i exponents.[index]) 
        |> Array.reduce (+)
    
    let toDecimal s = 
        s
        |> stringToIntArray
        |> isIntArrayAllBinary 
        |> intArrayToBaseTwo
