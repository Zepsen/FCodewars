open System

let tryDis n m = 
    if m % n = 0 then 
        if n = m / n then n
        else n + m / n
    else 0

let dis (m:int) = 
    [2..(int32(Math.Sqrt(float m)))] 
    |> List.sumBy (fun el -> tryDis el m) 

let test n =
    let f1 = dis n
    if f1 > n then 
        let f2 = dis f1    
        (n = f2, (f2, f1))
    else (false, (0, 0))

let buddy (start: int) (nd: int): (int * int) option = // your code
    match [start..nd] |> List.tryPick (fun el -> 
            let (valid, res) = test el
            if valid then Some(res) else None) with
    | Some(x, y) -> Some(x, y)
    | _ -> None

buddy 10 50

