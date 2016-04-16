open System

let No275 () =
    let N = int <| Console.ReadLine()
    let A = (fun e-> Console.ReadLine().Split(' ') |> Array.map float |> Array.sort) ()
    if N % 2 <> 0 then
        printfn "%f" A.[N/2]
    else
        printfn "%f" <| (A.[N/2] + A.[N/2-1]) / 2.

    ()

No275 ()

