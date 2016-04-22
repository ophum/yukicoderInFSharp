open System

let No98 () =
    let IN = Console.ReadLine().Split(' ')
    let x, y = Double.Parse IN.[0], Double.Parse IN.[1]

    let d = sqrt(x ** 2. + y ** 2.) * 2. + 1.
    printfn "%d" <| int d
    ()

No98 ()
