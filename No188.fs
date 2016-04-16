open System

let No188 () =
    let dt = DateTime.Parse("2015/01/01")

    let rec CountHappyDay (DT:DateTime) (c:int) =   // dateTime count
        let m = DT.Month
        let d = DT.Day

        if m = 12 && d = 31 then
            c
        else 
            let l, h = d % 10, (d / 10) % 10
            let DT = DT.AddDays(1.)
            if l + h = m then
                CountHappyDay DT (c + 1)
            else
                CountHappyDay DT c
    
    printfn "%d" <| CountHappyDay dt 0

    ()
No188 ()
