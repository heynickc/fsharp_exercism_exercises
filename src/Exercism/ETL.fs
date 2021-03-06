﻿namespace Exercism

module ETL = 
    let transform (l : Map<int, string list>) = 
        seq { 
            for i in l do
                for j in i.Value do
                    yield (j.ToLower(), i.Key)
        }
        |> Map.ofSeq