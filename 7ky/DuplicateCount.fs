
let duplicateCount (text:string) = 
    text.ToLower()
    |> Seq.countBy(id)
    |> Seq.filter(fun(k,v) -> v > 1)
    |> Seq.length
    

let bestDuplicateCount (text:string) = 
    text.ToLower()
    |> Seq.countBy(id)
    |> Seq.filter(snd >> (<)1)
    |> Seq.length


bestDuplicateCount "asdasdadasdagADSFF"    