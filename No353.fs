open System

let No353 () =
    let IN = stdin.ReadLine().Split(' ')
    let A, B = Int32.Parse IN.[0], Int32.Parse IN.[1]

    let res = A - (-1 * B)
    printfn "%d" res
    ()

No353 ()

