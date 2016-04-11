open System

let rec No304 (n:int) =
    if n = 0 || Console.ReadLine() = "locked" then
        printfn "%03d" n
        No304 (n+1)
    else
        ()

No304 0
