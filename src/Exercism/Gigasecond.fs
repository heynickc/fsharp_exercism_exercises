namespace Exercism

module Gigasecond = 

    open System
   
    let gigasecond (input:DateTime) = 
        let gigaseconds = int ((float 10)**(float 9))
        let timeSpan = TimeSpan(0, 0, gigaseconds)
        input.Add(timeSpan).Date



