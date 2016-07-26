module ZipFilterUnzipFormat

let fac0102 = @"59|61|62|63|64|66|67|68|69|71|72|73|74|76|77|78|79|81|82|83|84|87|129|151|152|158|163"

let fac02 = @"500|510|515|520|525|526|527|528|529|531|535|545|560|565|568|570|571|575|580|581|582|585|781|961|963|OBS02|SUB2";;

let fac03 = @"||||||||||||||||||||||718|720|721|722||723|724|738||740|742|746|747||748|750|751|753||754|755|756|757||759|||785|786||||903|907|||||||OBS03|||SUB3||||||||||||||237|350|355|360|365|370|375|380|385|390||||||||"

let splitFacStr (s : string) = s.Split '|'

let zip2Facilities arr1 arr2 = Array.zip arr1 arr2

let filterEmptyWCs arr = arr |> Array.filter (fun (x, y) -> x <> "" && y <> "")

let unzipFilteredFacilities arr = Array.unzip arr

let stringifyFilteredWCs arr = arr |> Array.reduce (fun acc item -> acc + @"|" + item)

open System.IO
let writeToFile fileName (txt:string) = 
    let outp = File.CreateText (@"C:\Users\nchamberlain\Desktop\" + fileName)
    outp.WriteLine txt
    outp.Close()