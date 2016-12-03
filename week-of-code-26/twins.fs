open System

let rec primeHelper x n =
  match n with
  | 0 | 1 -> true
  | _ ->
      if x % n = 0 then false
      else primeHelper x (n - 1)

let isPrime x =
    let l = System.Math.Sqrt (float x)
    primeHelper x (int l)

let isDiff2 (a:int) (b:int) =
  Math.Abs(a-b) = 2

let removeDuplicates p =
  Seq.distinct (Seq.map (fun (a,b) -> if a < b then (a,b) else (b,a)) p)

[<EntryPoint>]
let main argv = 
  let str = Console.ReadLine() |> string
  let input = str.Split(' ') |> Array.map (fun x -> Int32.Parse(x))
  let pairs = Seq.filter (fun (a,b) -> isPrime(a) && isPrime(b)) (Seq.filter (fun (a,b) -> isDiff2 a b) (seq{for a in input.[0]..input.[1] do for b in input.[0]..input.[1] do yield a,b}))
  //printfn "%A" pairs
  let newPairs = removeDuplicates pairs
  //printfn "%A" newPairs
  printfn "%d" (Seq.length newPairs)
  0
  