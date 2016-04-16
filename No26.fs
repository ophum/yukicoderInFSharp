open System

let No26 () =
    let N = int <| Console.ReadLine()
    let M = int <| Console.ReadLine()
    let rec res i n =
        if i < M then
            let IN = Console.ReadLine().Split(' ')
            let P, Q = Int32.Parse IN.[0], Int32.Parse IN.[1]
            if n = P then
                res (i + 1) Q
            elif n = Q then
                res (i + 1) P
            else 
                res (i + 1) n
        else
            n
    printfn "%d" <| res 0 N
    ()

No26 ()
