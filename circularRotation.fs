open System

// let rightRotate2 (a:int list) =
//   let last = a.[a.Length-1]
//   last::a.[0..(a.Length-2)]

// let rec rightRotateTimes a n =
//   if n = 0 then a
//   else
//     printfn "rotating...%d" (n-1)
//     rightRotateTimes (rightRotate2 a) (n-1)

let rightRotate (a:int list) n =
  let x = if n > a.Length then n % a.Length else n
  if x = a.Length then a
  else a.[(a.Length-x)..a.Length-1]@a.[0..(a.Length-x-1)]
  //a.[3-2+1..2] @ a.[0..1] => a.[2..2]

let rec procinput lines n =
  if n = 0 then List.rev lines |> List.map (fun x -> Int32.Parse(x))
  else
  match Console.ReadLine() with
  | null -> lines |> List.map (fun x -> Int32.Parse(x))
  | s -> procinput (s::lines) (n-1)

[<EntryPoint>]
let main argv = 
  let input = Console.ReadLine() |> string
  let inarray = input.Split(' ') |> Array.map (fun x -> Int32.Parse(x))
  printfn "r=%A" inarray
  let str = Console.ReadLine() |> string
  let numbers = Array.toList (str.Split(' ')) |> List.map (fun x -> Int32.Parse(x))
  printfn "n=%A" numbers
  //let rotatedArray = rightRotateTimes numbers inarray.[1]
  let rotatedArray = rightRotate numbers inarray.[1]
  printfn "r=%A" rotatedArray
  let indexes = procinput [] inarray.[2]
  printfn "i=%A" indexes
  for i in 0..(inarray.[2]-1) do
    Console.WriteLine("{0}", rotatedArray.[ indexes.[i] ])
  0 