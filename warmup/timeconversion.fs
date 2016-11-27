open System

[<EntryPoint>]
let main argv = 
    let time = Console.ReadLine() |> string
    let hour = time.[0..1] |> Int32.Parse
    if time.IndexOf("AM") > 0 then
      let amHour = if hour = 12 then "00"
                   elif hour < 9 then "0" + hour.ToString() 
                   else hour.ToString()
      Console.WriteLine("{0}{1}", amHour, time.[2..7])
    else
      let pmhour = if hour = 12 then 12 else (hour + 12)
      Console.WriteLine("{0}{1}", pmhour, time.[2..7])
    0