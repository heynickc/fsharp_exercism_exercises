namespace Exercism

module Binary = 

    let (|IsAllNumbers|_|)  (s:string) =
        if String.forall System.Char.IsNumber s
        then Some() else None

    let (|IsAllBinaryDigits|_|) (ia : int option []) =
        if Array.forall (fun j -> Option.get j < 2) ia
        then Some() else None

    let parseCharToInt (c : char) = 
        let (couldParse, parsedInt) = System.Int32.TryParse(System.Char.ToString(c))
        match couldParse with
        | true -> Some(parsedInt)
        | false -> None      

    let createIntArray (s : string) =
        Array.init s.Length (fun n -> parseCharToInt (s.Chars(n)))

    let stringToIntArray (s : string) = 
        match s with
        | IsAllNumbers -> createIntArray s
        | _ -> [| Some(0) |]
    
    let isIntArrayAllBinary (ia : int option []) =
        match ia with
        | IsAllBinaryDigits -> ia
        | _ -> [| Some(0) |]

    let intToBaseTwo (i : int option) (pos : int) = 
        match i with
        | Some j -> j * (pown 2 pos)
        | None -> 0
    
    let intArrayToBaseTwo (intarray : int option []) = 
        let exponents = [| (intarray.Length - 1) .. -1 .. 0 |]
        intarray |> Array.mapi (fun index i -> intToBaseTwo i exponents.[index]) |> Array.reduce (+)
    
    let toDecimal (s : string) = stringToIntArray s |> isIntArrayAllBinary |> intArrayToBaseTwo
