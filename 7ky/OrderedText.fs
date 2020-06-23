

let orderedText (text:string) =    
    text 
    |> Seq.groupBy (fun x -> x) 
    |> Seq.map (fun (k, v) -> (k, Seq.length v ))
    |> Seq.toList
    
let bestOrderedText text =
    text |> Seq.countBy(id) |> Seq.toList    

orderedText "adsfasdfa"
bestOrderedText "adsfasdfa"