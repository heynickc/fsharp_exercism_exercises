namespace Exercism

module SpaceAge = 

    type Planet =
        | Earth
        | Mercury
        | Venus
        | Mars
        | Jupiter
        | Saturn
        | Uranus
        | Neptune

    let coefficient planet =
        match planet with
        | Earth -> 1m
        | Mercury -> 0.2408467m
        | Venus -> 0.61519726m
        | Mars -> 1.8808158m
        | Jupiter -> 11.862615m
        | Saturn -> 29.447498m
        | Uranus -> 84.016846m
        | Neptune -> 164.79132m

    let earthYear = 31557600m

    let round (n:decimal) = System.Math.Round(n, 2)

    let spaceAge planet seconds = 
        let planetCoefficient = coefficient planet
        round (seconds/(earthYear*planetCoefficient))
