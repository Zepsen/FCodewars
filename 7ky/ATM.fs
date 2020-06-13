
let folder (res, n) nom =
    if n >= nom
    then (res + n/nom, n - nom*(n/nom))
    else (res, n)

let solve n =
    let res = List.fold folder (0, n) [500; 200; 100; 50; 20; 10;]
    if snd res > 0 then -1 else fst res

solve 1230