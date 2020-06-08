
let plusplus a b c = a + b + c
let plusmult a b c = a + b * c
let PLUSmult a b c = (a + b) * c
let multplus a b c = a * b + c
let multPLUS a b c = a * (b + c)
let multmult a b c = a * b * c

let list = [plusplus; plusmult; PLUSmult; multplus; multPLUS; multmult;]

let expressionMatter (a:int, b:int, c:int) =        
    List.map (fun f -> f a b c) list |> List.max
    
let test a b c = 
    List.map (fun f -> f a b c) [plusplus; plusmult; PLUSmult; multplus; multPLUS; multmult]
    |> List.max

let best (a:int) (b:int) (c:int) : int =
    [a+b+c; a+b*c; (a+b)*c; a*b*c; a*b+c; a*(b+c) ] |> List.max

expressionMatter (1, 1, 1)
best 1 2 3 