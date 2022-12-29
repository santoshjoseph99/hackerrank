open System

let list =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <- Console.ReadLine()
    ]

let rec reverse l out =
  match l with
  | [] -> out
  | head::tail -> reverse tail (head::out)

let intList = list |> List.map (fun x -> Int32.Parse x)
let result = reverse intList []
List.iter (fun elem -> printf "%d\n" elem) result