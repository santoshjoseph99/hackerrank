open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    for i in 1..n do
      for s in 1..(n-i) do
        Console.Write(" ")
      for a in (n-i)..n-1 do
        Console.Write("#")
      Console.WriteLine("")
    0