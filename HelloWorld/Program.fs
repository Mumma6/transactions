open System

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from transactions")

    Transactions.Driver.UserConsole.userLoop ()

    Console.WriteLine("Bye")
    0
