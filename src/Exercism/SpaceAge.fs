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

    let spaceAge planet seconds = 
        let earthSeconds = 31557600m
        let round (n:decimal) = System.Math.Round(n, 2)
        match planet with
        | Earth -> round (seconds/earthSeconds)
        | Mercury -> round (seconds/(earthSeconds*0.2408467m))
        | Venus -> round (seconds/(earthSeconds*0.61519726m))
        | Mars -> round (seconds/(earthSeconds*1.8808158m))
        | Jupiter -> round (seconds/(earthSeconds*11.862615m))
        | Saturn -> round (seconds/(earthSeconds*29.447498m))
        | Uranus -> round (seconds/(earthSeconds*84.016846m))
        | Neptune -> round (seconds/(earthSeconds*164.79132m))
        | _ -> 0m

