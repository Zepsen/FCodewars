let isPrime (n:int64) =
    let rec test (i:int64) = 
        if i * i <= n then
            if (n % i = 0L || n % (i + 2L) = 0L) then
                false
            else test (i + 6L)
        else true    
    
    if n <= 3L then 
        n > 1L
    elif (n % 2L = 0L || n % 3L = 0L) then
        false
    else test 5L

let step(g:int64, m:int64, n:int64): int64 list =
    let primes = [m..n] |> List.filter isPrime     
    match primes |> List.tryFind (fun x -> primes |> List.contains (x + g)) with
    | Some value -> [value; value + g]
    | None -> []

step (6L, 100L, 108L)


//Best variant 
let isPrime n =
    seq { for i in 2L..(n |> float |> sqrt |> int64) do yield n % i  }
    |> Seq.tryFind (fun rem -> rem = 0L)
    |> Option.isNone

let step(g, m, n) =
    let firstPrimeInStep = 
        seq {m..n}
        |> Seq.tryFind (fun i -> 
            let upperNum = i + g
            (i |> isPrime) && upperNum <= n && (upperNum |> isPrime))
    match firstPrimeInStep with
    | Some p -> [p; p + g]
    | None -> []