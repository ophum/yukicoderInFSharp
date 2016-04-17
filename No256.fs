let No256 () =
    [
        let IN = Console.ReadLine()
        for i in 0..IN.Length-1 -> (Int32.Parse (string IN.[i]))
    ]
    |> List.sort
    |> List.rev
    |> List.iter (printf "%d")
    ()
 
No256 ()
