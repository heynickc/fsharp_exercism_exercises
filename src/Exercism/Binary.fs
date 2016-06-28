namespace Exercism

module Binary = 
    let parseCharToInt (c : char) = 
        let (couldParse, parsedInt) = System.Int32.TryParse(System.Char.ToString(c))
        if couldParse then Some(parsedInt)
        else None
    
    let toDecimal (s : string) = 
        //        if String.forall System.Char.IsNumber s then
        Array.init s.Length (fun n -> parseCharToInt (s.Chars(n)))
