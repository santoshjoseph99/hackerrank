
//   0 1 2
// 0 0 0 0
// 1 0 0 0
// 2 0 0 0

//   0 1 2 3 4
// 0 0 0 0 0 0
// 1 0 0 0 0 0
// 2 0 0 0 0 0
// 3 0 0 0 0 0
// 4 0 0 0 0 0

//   0 1 2 3 4 5
// 0 0 0 0 0 0 0
// 1 0 0 0 0 0 0
// 2 0 0 0 0 0 0
// 3 0 0 0 0 0 0

// both n & m even then n*m/4
// if n & m = 1 then 1
// if n & m = 2 then 1

// if n or m is odd then sub -1 to either or both then solve that problem

// add up the row/col - if odd then m+n/2, if even then 

open System

let rec calcArmyDrop m n =
  //Console.WriteLine("{0} {1} {2} {3} {4} {5}", m, n, (n*m)/4, (m/2), (n/2), (m+n)/2)
  let r = if m <= 2 && n <= 2 then 1
          elif m = 1 then Convert.ToInt32(ceil((float n)/(float 2)))
          elif n = 1 then Convert.ToInt32(ceil((float m)/(float 2)))
          elif m % 2 = 0 && n % 2 = 0 then (n*m)/4
          elif m % 2 = 0 then (calcArmyDrop m (n-1)) + (m/2)
          elif n % 2 = 0 then (calcArmyDrop (m-1) n) + (n/2)
          else (calcArmyDrop (m-1) (n-1)) + ((m+n)/2) + 1
  //Console.WriteLine("r={0}",r)
  r

[<EntryPoint>]
let main argv = 
    let str = Console.ReadLine() |> string
    let input = str.Split(' ') |> Array.map (fun x -> Int32.Parse(x))
    let result = calcArmyDrop input.[0] input.[1]
    Console.WriteLine("{0}", result)
    0
    