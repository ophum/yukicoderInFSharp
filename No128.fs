open System

let No128 () =
    let N = int64 <| Console.ReadLine()
    let M = int64 <| Console.ReadLine()

    let N = N / 1000L
    let N = N / M
    printfn "%d" (N * 1000L)
    ()

No128 ()
