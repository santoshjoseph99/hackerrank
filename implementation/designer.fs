open System

[<EntryPoint>]
let main argv = 
  let str = Console.ReadLine() |> string
  let input = str.Split(' ') |> Array.map (fun x -> Int64.Parse(x))
  let total = Array.sum input
  let sums = seq{for x in 0..4 do yield total - input.[x]}
  printf "%d %d" (Seq.min sums) (Seq.max sums)
  0
  