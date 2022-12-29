//Enter your code here. Read input from STDIN. Print output to STDOUT
open System

let list =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <- Console.ReadLine()
    ]

let rec filterEven (x:int) l out =
  match l with
  | [] -> out
  | head::tail -> if x % 2 = 0 then filterEven (x+1) tail out else (filterEven (x+1) tail (out@[head]))

let intList = list |> List.map (fun x -> Int32.Parse x)
let result = filterEven 0 intList []
List.iter (fun elem -> printf "%d\n" elem) result
