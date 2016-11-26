open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let numbers = Console.ReadLine() |> string
    let sum = numbers.Split(' ') |> Array.map (fun x -> Int64.Parse(x)) |> Array.sum
    Console.WriteLine("{0}", sum);
    0