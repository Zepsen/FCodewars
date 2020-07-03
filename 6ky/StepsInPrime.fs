
let isPrime (n:int64) =
    [2L..n-1L]
    |> List.forall (fun x -> n % x <> 0L) 

let primesUpTo (m:int64) (n:int64): int64 list = 
   let rec sieve l: int64 list  = 
      match l with 
      | [] -> []
      | p::xs -> 
            p :: sieve [for x in xs do if (x % p) > 0L then yield x]   
   
   [2L..n] |> sieve |> List.filter (fun x -> x > m)

let takePrimes (m:int64) (n:int64): int64 list = 
    [m..n]



let step(g:int64, m:int64, n:int64): int64 list =
    //let primes = [m..n] |> List.filter isPrime 
    let primes = primesUpTo m n
    match primes |> List.tryFind (fun x -> primes |> List.contains (x + g)) with
    | Some value -> [value; value + g]
    | None -> []

step (6L, 100L, 108L)