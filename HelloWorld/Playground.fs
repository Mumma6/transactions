module PlayGroundTesting

let name = "martin"
let age: int = 31

let suit (no: int) : string =
    let suitNo: int = no / 13

    if suitNo = 0 then "Hearts"
    elif suitNo = 1 then "Spades"
    elif suitNo = 2 then "Diamonds"
    else "Clubs"

let cardDescription (card: int) : string =
    let cardNo: int = card % 13

    if cardNo = 1 then "Ace"
    elif cardNo = 11 then "Jack"
    elif cardNo = 12 then "Queen"
    elif cardNo = 0 then "King"
    else string cardNo


let cards = [ 1; 10; 8; 12 ]

for card in cards do
    printfn "%s of %s" (cardDescription (card)) (suit (card))

let add (x: int) = x + 5
let multiply x = x * 3

let convertInToString (x: int) : string = "The number is: " + string x

let addMult = add >> multiply

let val2 = 5 |> addMult |> convertInToString


let bigNumbers = [ 10; 20; 30; 40 ]
let numbers = [ 1..8 ] |> List.append bigNumbers
let sortNumbers (nums: int list) = List.sort nums

let printNumbers (nums: int list) =
    List.iter (fun x -> printfn "item %i" x) nums

let sortnprint = sortNumbers >> printNumbers
let nums = numbers |> sortnprint
let nums2 = sortnprint numbers
let nums3 = numbers |> sortNumbers |> printNumbers

let nummms = bigNumbers |> List.map (fun x -> x * 2)

let printer x = printfn "%A" x

type Person = { FirstName: string; LastName: string }
type Person2 = { age: string; mobile: string }

let people =
    [ { FirstName = "Albert"
        LastName = "Einstein" }

      { FirstName = "Marie"
        LastName = "Curie" } ]

let names = people |> List.map (fun x -> x.FirstName + x.LastName)
printer names

let finePeople ns name =
    let found = ns |> List.tryFind (fun n -> n = name)

    match found with
    | Some value -> printfn "%i" value
    | None -> printfn "Not found"


type OrderItem = { Name: string; Cost: int }

let orderItems =
    [ { Name = "XBox"; Cost = 500 }
      { Name = "Book"; Cost = 10 }
      { Name = "Movie ticket"; Cost = 7 } ]

let sum = List.sumBy (fun item -> item.Cost) orderItems
printfn "%i" sum // 517


let myTuple = (42, "hello")
let number, message = myTuple
