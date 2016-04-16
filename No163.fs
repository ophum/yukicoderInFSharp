open System

let No163 () =
    let diff = int 'a' - int 'A'
    Console.ReadLine()
    |> String.map (fun e-> if e >= 'a' then char (int e - diff) else char (int e + diff))
    |> printfn "%s"

    ()

No163 ()

