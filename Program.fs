// Learn more about F# at http://fsharp.org

open System
// Ex1
let fil x = 
    printfn "Val %b val:%d" (x%3 = 0 || x%5 = 0) x
    x%3 = 0 || x%5 = 0
let sumMod3Mod5 n = 
   [1..n] |> List.filter fil |> List.sum


// Fibonacci infite sequence
let fibSeq = Seq.unfold (fun (a,b) -> Some( a+b, (b, a+b) ) ) (0,1)
// Sum of even
let fibAddEven limit = fibSeq |> Seq.takeWhile (fun x -> x<=limit ) |> Seq.filter (fun x -> x%2=0) |> Seq.sum

// Prime Checker
let isPrime n =
    let rec check i =
        i > n/2L || (n % i <> 0L && check (i + 1L))
    check 2L
// let isPrime n =
//   let sqrt' = (float >> sqrt >> int) n // square root of integer
//   [ 2 .. sqrt' ] // all numbers from 2 to sqrt'
//   |> List.forall (fun x -> n % x <> 0) // no divisors
let primeDivisor value = [2L..value] |> List.filter (fun x -> value%x=0L ) |> List.filter isPrime |> List.max
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    // let op = fact(0, 10)
    // let op = sumMod3Mod5 999
    // let op = fibAddEven 4000000
    let op = primeDivisor 600851475143L
    Console.WriteLine("Resultado: {0}", op)
    0 // return an integer exit code
