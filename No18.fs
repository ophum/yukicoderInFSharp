open System

let No18 () =
    let S = Console.ReadLine()
    let deciper (C:char) (N:int) =
        let C = int C - int 'A'
        let N = N % 26
        let C = C - N
        if C < 0 then
            char (int 'Z' + C + 1)
        else
            char (int 'A' + C)

    for i in 1..S.Length do
        printf "%c" (deciper S.[i-1] i)
    done
    printfn ""
    ()
No18 ()
