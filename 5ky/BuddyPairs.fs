let dis m = 
    [1..m-1] 
    |> List.sumBy (fun el -> if m % el = 0 then el else 0) 

let test n =
    let f1 = dis n
    if f1 > n then 
        let f2 = dis (f1 - 1)    
        n + 1 = f2
    else false

let buddy (start: int) (nd: int): (int * int) option = // your code
    match [start..nd] |> List.tryFind test with
    | Some res -> Some(res, dis res - 1)
    | _ -> None

buddy 10 50

test 48