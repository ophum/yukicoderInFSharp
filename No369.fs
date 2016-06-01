open System

let No369 () =
    ignore(Console.ReadLine())
    let sum = Console.ReadLine().Split(' ')
                |> Array.map Int32.Parse
                |> Array.sum
    let v = int <| Console.ReadLine()
    printfn "%d" (sum - v)
    ()

No369 ()
