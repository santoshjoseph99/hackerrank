open System

let rec divisors num n a =
  if num = 0 then [0]
  elif num = n then List.rev (n::a)
  else 
    if num % n = 0 then divisors num (n+1) (n::a)
    else divisors num (n+1) a

let rec sumOfDigits orgNum num sum =
  if num = 0 then (orgNum,sum)
  else sumOfDigits orgNum (num/10) (sum + num % 10)

let compare (a1,b1) (a2,b2) =
  if b1 > b2 then 1
  elif b1 < b2 then -1
  elif a1 > a2 then -1
  elif a2 < a1 then 1
  else 0

let calcMax a =
  let sorted = List.sortWith compare a
  //printfn "sorted = %A" sorted
  List.last sorted

[<EntryPoint>]
let main argv = 
  let num = Console.ReadLine() |> int 
  let divs = divisors num 1 []
  //printfn "divisors = %A" divs
  let sums = List.map (fun x -> sumOfDigits x x 0) divs
  //printfn "sums = %A" sums
  let (n,s) = calcMax sums
  // let (n,s) = divisors num 1 []
  //            |> List.map (fun x -> sumOfDigits x x 0)
  //            |> calcMax
  printfn "%d,%d" n s
  0
  