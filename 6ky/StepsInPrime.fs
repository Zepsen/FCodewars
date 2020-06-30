
let isPrime (n:int64) =
    [2L..n-1L]
    |> List.forall (fun x -> n % x <> 0L) 

let step(g:int64, m:int64, n:int64): int64 list =
    let primes = [m..n] |> List.filter isPrime 
    match [0..primes.Length - 2] |> List.tryFind (fun x -> primes.[x+1] - primes.[x] = g) with
    | Some value -> [int64(primes.[value]); int64(primes.[value + 1])]
    | None -> []
    


step (6L, 100L, 108L)