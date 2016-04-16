open System

let No24 () =
    let N = int <| Console.ReadLine()
    let A = Array.create 10 0
    let yes n =
        if A.[n] <> -1 then
            A.[n] <- A.[n] + 1

        ()

    let rec max i m =
        if i < 10 then
            if A.[i] > m then
                max (i + 1) A.[i]
            else
                max (i + 1) m
        else
            m

    for i in 0..N-1 do
        let IN = Console.ReadLine().Split(' ')
        let L = [ for i in 0..3 -> Int32.Parse IN.[i] ]
        if IN.[4] = "YES" then
            L |> List.iter yes
        else
            L |> List.iter (fun e -> A.[e] <- -1)
    
    let m = max 0 0
    A
    |> Array.findIndex (fun e-> if e = m then true else false)
    |> printfn "%d"

    ()
No24 ()
