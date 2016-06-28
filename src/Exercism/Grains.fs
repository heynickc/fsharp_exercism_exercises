namespace Exercism

module Grains = 
    let square n = 2I ** (n - 1)
    let total = [| 1..64 |] |> Array.sumBy square
