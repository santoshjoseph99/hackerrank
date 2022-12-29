//Enter your code here. Read input from STDIN. Print output to STDOUT
open System

let replicate n l =
  l |> List.map (fun x -> List.init n (fun i -> x)) |> List.concat

let s = Console.ReadLine() |> int
let list =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <- Console.ReadLine()
    ]
//Console.WriteLine("{0}", list)

let result = replicate s list
//List.iter (fun x -> printf("%s\n", x)) result
List.iter (fun elem -> printf "%s\n" elem) result
//Console.WriteLine("{0}", result)
