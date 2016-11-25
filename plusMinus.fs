// The entire code is given, you can just review and submit!
open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let str = Console.ReadLine() |> string
    let numbers = str.Split(' ') |> 
                  Array.map (fun x -> Int32.Parse(x))

    let sum (p,m,z) e =
      if e > 0 then (p+1,m,z)
      elif e < 0 then (p,m+1,z)
      elif e = 0 then (p,m,z+1)
      else (0,0,0)

    let (p, m, z) = Array.fold sum (0,0,0) numbers
    Console.WriteLine("{0}", float p/ float n); 
    Console.WriteLine("{0}", float m/ float n); 
    Console.WriteLine("{0}", float z/ float n); 
    0 // return an integer exit code