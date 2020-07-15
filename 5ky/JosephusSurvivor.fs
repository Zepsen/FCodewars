let josephusSurvivor n k =
    let idx  f = f + k - 1
    let rec go (arr:array<int>) from =
        match arr.Length with
        | 1 -> arr         
        | _ ->  let ix = idx from
                if ix < arr.Length then
                    let innerArr = Array.concat [arr.[..(ix-1)]; arr.[(ix+1)..]] 
                    go innerArr ix
                else 
                    go arr (from - arr.Length)     
    
    (go [|1..n|] 0).[0]

josephusSurvivor 300 300 
    

let josephusSurvivorBest (n: int) (k: int) =
  let rec josephusInternal(n: int, k: int) =
    if n = 1 then 1
    else (josephusInternal(n - 1, k) + k-1) % n + 1
      
  josephusInternal(n, k)