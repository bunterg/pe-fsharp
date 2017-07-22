// Learn more about F# at http://fsharp.org

open System
// forma con recursion
let filtrar x =
    if x%3=0 || x%5=0 then x
    else 0
let rec fact (sum:int, x:int) =
    if x < 1 then sum
    else fact(sum + filtrar x, x - 1)

// forma con lista
let fil x = 
    printfn "Val %b val:%d" (x%3 = 0 || x%5 = 0) x
    x%3 = 0 || x%5 = 0
let sumMod3Mod5 n = 
   [1..n] |> List.filter fil |> List.sum

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    // let op = fact(0, 10)
    let op = sumMod3Mod5 999
    printfn "Resultado: %d" op
    0 // return an integer exit code
