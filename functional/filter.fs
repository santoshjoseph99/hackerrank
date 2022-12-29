open System

let s = Console.ReadLine() |> int
let list =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <- Console.ReadLine()
    ]

let rec filter (x:int) l out =
  match l with
  | [] -> out
  | head::tail -> if head < x then filter x tail (head::out) else (filter x tail out)

let intList = list |> List.map (fun x -> Int32.Parse x)
let result = filter s intList []
List.iter (fun elem -> printf "%d\n" elem) result
