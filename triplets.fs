// The entire code is given, you can just review and submit!
open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let numbers = Console.ReadLine() |> string
    let sum = numbers.Split(' ') |> Array.map (fun x -> Int64.Parse(x)) |> Array.sum
    Console.WriteLine("{0}", sum);
    0 // return an integer exit code