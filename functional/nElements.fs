
let rec fHelper (n:int) out =
  match n with
  | 0 -> out
  | _ -> fHelper (n-1) (n::out)

let f n = //Complete this function
  fHelper n []