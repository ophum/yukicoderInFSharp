open System

let No143 () =
    let IN = Console.ReadLine().Split(' ')
    let B = (Int32.Parse IN.[0]) * (Int32.Parse IN.[1])
    let last n = 
        if B - n < 0 then
            printfn "-1"
        else
            printfn "%d" (B - n)

    Console.ReadLine().Split(' ')
    |> Array.map Int32.Parse
    |> Array.sum
    |> last
    ()

No143 ()
