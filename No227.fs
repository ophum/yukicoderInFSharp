open System

let No227 () =
    let A = Array.zeroCreate 13
    let rec res (i:int) (th:int) (tw:int) =
        if i < A.Length then
            if A.[i] = 3 then
                res (i + 1) (th + 1) tw
            elif A.[i] = 2 then
                res (i + 1) th (tw + 1)
            else
                res (i + 1) th tw
        else
            match th, tw with
            | 1, 1 -> printfn "FULL HOUSE"
            | 1, 0 -> printfn "THREE CARD"
            | 0, 2 -> printfn "TWO PAIR"
            | 0, 1 -> printfn "ONE PAIR"
            | _, _ -> printfn "NO HAND"
            ()

    Console.ReadLine().Split(' ')
    |> Array.map Int32.Parse
    |> Array.iter (fun e -> A.[e-1] <- A.[e-1] + 1)
    res 0 0 0
    ()

No227 ()
