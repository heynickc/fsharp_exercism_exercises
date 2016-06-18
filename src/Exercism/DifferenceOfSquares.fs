namespace Exercism

module DifferenceOfSquares = 
    
    let square x = x * x

    let squareOfSums n =
        [1 .. n]
        |> Seq.sum 
        |> square

    let sumOfSquares n = 
        [1 .. n]
        |> Seq.map(square)
        |> Seq.sum

    let difference n =
        squareOfSums n - sumOfSquares n