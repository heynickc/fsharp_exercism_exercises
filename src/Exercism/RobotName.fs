namespace Exercism

module RobotName = 
    let random = new System.Random()
    let chars = [| 'A'..'Z' |]
    
    type Robot() =        
        let generateName() = 
            let letters = Array.init 3 (fun _ -> chars.[random.Next(0, 25)]) |> System.String.Concat
            let numbers = random.Next(100, 999).ToString()
            letters + numbers
        
        let mutable name = generateName()
        member r.Name = name
        member r.ResetName() = name <- generateName()
    
    let mkRobot() = Robot()
    let name (r : Robot) = r.Name
    
    let reset (r : Robot) = 
        r.ResetName()
        r
