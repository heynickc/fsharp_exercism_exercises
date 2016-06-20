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

    let secondsToEarthSeconds seconds conversion = 
        let earthSeconds = 31557600m
        let round (n:decimal) = System.Math.Round(n, 2)
        round (seconds/(earthSeconds*conversion))

    let spaceAge planet seconds = 
        match planet with
        | Earth -> secondsToEarthSeconds seconds 1m
        | Mercury -> secondsToEarthSeconds seconds 0.2408467m
        | Venus -> secondsToEarthSeconds seconds 0.61519726m
        | Mars -> secondsToEarthSeconds seconds 1.8808158m
        | Jupiter -> secondsToEarthSeconds seconds 11.862615m
        | Saturn -> secondsToEarthSeconds seconds 29.447498m
        | Uranus -> secondsToEarthSeconds seconds 84.016846m
        | Neptune -> secondsToEarthSeconds seconds 164.79132m
        | _ -> 0m

