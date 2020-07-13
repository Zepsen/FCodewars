let josephusSurvivor n k =
    let idx  f = f + k - 1
    let rec go (arr:array<int>) from =
        match arr.Length with
        | 1 -> arr         
        | _ -> if idx from < arr.Length then
                    let innerArr = arr 
                                   |> Array.mapi (fun i el -> (i <> idx from , el)) 
                                   |> Array.filter fst 
                                   |> Array.map snd                    
                    go innerArr (idx from)
               else 
                    go arr (from - arr.Length)     
    
    (go [|1..n|] 0).[0]

josephusSurvivor 11 19 
    