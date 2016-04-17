open System

let No69 () =
    let A = [ 
        let IN = Console.ReadLine() 
        for i in 0..IN.Length-1 -> IN.[i]
        ]
    let A = List.sort <| A
    let B = [
        let IN = Console.ReadLine()
        for i in 0..IN.Length-1 -> IN.[i]
        ]
    let B = List.sort <| B

    if A = B then
        printfn "YES"
    else
        printfn "NO"

    ()
 
No69 ()
