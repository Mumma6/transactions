module Transactions.Driver

open System

module UserConsole =

    let private promptUser () =
        Console.Write("d, w or x ")
        Console.ReadLine()

    let private getAmount () =
        Console.Write("Enter amount ")
        Console.ReadLine() |> Decimal.Parse

    let userLoop () =
        let mutable balance = 0m

        let mutable running = true

        while running do
            printfn "Balance: %A" balance

            let action = promptUser ()
            printfn "You told me this: %A" action

            balance <-
                match action with
                | "d" -> balance + getAmount ()
                | "w" -> balance - getAmount ()
                | _ ->
                    running <- action <> "x"
                    balance
