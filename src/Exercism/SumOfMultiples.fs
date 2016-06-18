namespace Exercism

module SumOfMultiples = 

    let containsAnyMultiplesOf divisors dividend = 
        List.exists(fun num -> dividend % num = 0) divisors

    let sumOfMultiples nums max =
        [2 .. max - 1]
        |> List.filter (containsAnyMultiplesOf nums)
        |> List.sum