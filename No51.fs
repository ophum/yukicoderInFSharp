open System

let No51 () =
    let W = int <| Console.ReadLine()
    let D = int <| Console.ReadLine()

    let rec yaruki (W:int) (D:int) =
        // printfn "%d %d" W D  // debug
        if D = 1 then
            W
        else
            let y = (W / D)
            let y = y / D
            yaruki (W-y) (D - 1)

    printfn "%d" (yaruki W D)
    ()

No51 ()
