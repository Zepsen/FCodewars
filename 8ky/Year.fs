
let year y =
    match y % 100 with
    | 0 -> y / 100
    | _ -> y / 100 + 1

year 1790
year 1900

