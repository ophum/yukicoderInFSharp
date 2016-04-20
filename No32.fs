open System

let No32 () =
    let L = int <| Console.ReadLine()
    let M = int <| Console.ReadLine()
    let N = int <| Console.ReadLine()
    
    let M = M + (N / 25)
    let N = N % 25
    
    let L = L + (M / 4)
    let M = M % 4
    
    let L = L % 10
    
    printfn "%d" <| L + M + N
    
    ()
No32 ()
