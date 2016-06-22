namespace Exercism

module BeerSong = 
    
    let lyrics i =
        match i with
        | i when i = 0 -> sprintf "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n"
        | i when i = 1 -> sprintf "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n"        
        | i when i = 2 -> sprintf "%d bottles of beer on the wall, %d bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n" i i
        | _ -> sprintf "%d bottles of beer on the wall, %d bottles of beer.\nTake one down and pass it around, %d bottles of beer on the wall.\n" i i (i - 1)

    let verse i =        
        lyrics i

    let verses start stop =
        let sb = new System.Text.StringBuilder()
        let rec buildVerses start stop = 
            if start >= stop then
                sb.Append(verse start).Append("\n") |> ignore
                buildVerses (start - 1) stop
        buildVerses start stop
        sb.ToString()

    let sing = verses 99 0