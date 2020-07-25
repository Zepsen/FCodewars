let dis m = 
    [1..m-1] 
    |> List.filter (fun el -> m % el = 0) 
    |> List.sum 

let test n =
    n + 1 = dis ((dis n) - 1)

let buddy (start: int) (nd: int): (int * int) option = // your code
    match [start..nd] |> List.tryFind test with
    | Some res -> Some(res, dis res)
    | _ -> None

buddy 1081130 1103735