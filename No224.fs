open System

let No224 () =
    let n = int <| Console.ReadLine()
    let S = Console.ReadLine()
    let T = Console.ReadLine()
    let mutable C = 0

    for i in 0..n-1 do
        if S.[i] <> T.[i] then
            C <- C + 1
    done

    printfn "%d" C

    ()

No224 ()
