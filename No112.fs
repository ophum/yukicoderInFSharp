open System
 
let No112 () =
    let N = int <| Console.ReadLine()
    let A = Console.ReadLine().Split(' ') |> Array.map Int32.Parse |> Array.sort
    let t n s = (4 * n - s) / 2
 
    let a = (fun a b ->
        if a = b && a <> 0 then a + 1
        elif a > b then a
        else b) (t (N - 1) A.[0]) (t (N - 1) A.[A.Length - 1])
    printfn "%d %d" a (N - a)
    ()
 
No112 ()
