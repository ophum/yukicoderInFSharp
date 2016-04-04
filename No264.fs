open System

let No264 () =
    let IN = Console.ReadLine().Split(' ')
    let N, K = Int32.Parse IN.[0], Int32.Parse IN.[1]

    if N = K then
        printfn "Drew"
    elif N + 1 = K || ( N + 1 = 3 && K = 0 )then
        printfn "Won"
    else
        printfn "Lost"

    ()

No264 ()
