open System

let rec No35 (N:int) (s:int) (m:int) =
    if N > 0 then
        let IN = Console.ReadLine().Split(' ')
        let T, S = Int32.Parse IN.[0], IN.[1]
        let ct = 12 * T / 1000
        if ct > S.Length then
            No35 (N-1) (s+S.Length) m
        else
            No35 (N-1) (s+ct) (m+(S.Length-ct))
    else
        printfn "%d %d" s m

No35 (Int32.Parse (Console.ReadLine())) 0 0
