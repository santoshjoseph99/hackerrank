// The entire code is given, you can just review and submit!
open System

let createIntArray (str:string) =
  str.Split(' ') |> Array.map(fun x -> Int32.Parse(x))

let rec getDiagonalSumRight x y (a:int[,]) (s:int) =
  if x = Array2D.length1 a then s else getDiagonalSumRight (x+1) (y+1) a (s + a.[x,y])

let rec getDiagonalSumLeft x y (a:int[,]) (s:int) =
  if x = Array2D.length1 a then s else getDiagonalSumLeft (x+1) (y-1) a (s + a.[x,y])

// let printGrid (grid:int[,]) =
//     let maxY = (Array2D.length1 grid) - 1
//     let maxX = (Array2D.length2 grid) - 1
//     for row in 0 .. maxY do
//         for col in 0 .. maxX do
//             Console.Write("{0} ", grid.[row,col])
//         Console.WriteLine()

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let grid = Array2D.zeroCreate<int> n n
    for i in 0 .. n-1 do
      let numbers = Console.ReadLine() |> string
      let row = numbers.Split(' ') |> Array.map (fun x -> Int32.Parse(x))
      for x in 0 .. n-1 do
        grid.[i, x] <- row.[x]
    //printGrid grid
    let sum1 = getDiagonalSumRight 0 0 grid 0
    let sum2 = getDiagonalSumLeft 0 (n-1) grid 0
    Console.WriteLine("{0}", Math.Abs(sum1-sum2))
    0 // return an integer exit code