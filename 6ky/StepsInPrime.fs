
let isPrime (n:int64) =
    [2L..n-1L]
    |> List.forall (fun x -> n % x <> 0L) 

let step(g:int64, m:int64, n:int64): int64 list =
    let primes = [m..n] |> List.filter isPrime 
    match primes |> List.tryFind (fun x -> primes |> List.contains (x + g)) with
    | Some value -> [value; value + g]
    | None -> []

step (2L, 2L, 22L)