namespace Exercism

module SumOfMultiples = 

    let multiMultiples nums candidate = 
        let numMultiples = List.filter(fun x -> candidate % x = 0) nums |> List.length
        match numMultiples with
        | 0 -> 0
        | _ -> candidate

    let sumOfMultiples nums max =
        let numsToCheck = [2 .. max - 1]
        let bothMultiples = List.map(multiMultiples nums) numsToCheck
        List.sum bothMultiples