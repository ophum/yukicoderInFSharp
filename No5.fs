open System

let No5 () =
    let L = int <| Console.ReadLine()
    let N = int <| Console.ReadLine()
    let A = (fun e-> Console.ReadLine().Split(' ') |> Array.map Int32.Parse |> Array.sort ) ()

    let rec last (i:int) (s:int) (c:int) =
        if i < N && s + A.[i] <= L then
            last (i + 1) (s + A.[i]) (c + 1)
        else
            c

    printfn "%d" <| last 0 0 0
    ()

No5 ()
