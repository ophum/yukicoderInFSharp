open System

let No64 () =
    let IN = Console.ReadLine().Split(' ')
    let F0 = int64 <| IN.[0]
    let F1 = int64 <| IN.[1]
    let N  = int64 <| IN.[2]

    let xfib =
        [
            yield F0
            yield F1
            yield F0 ^^^ F1
        ]
    printfn "%d" xfib.[int(N % 3L)]
    ()

No64 ()
