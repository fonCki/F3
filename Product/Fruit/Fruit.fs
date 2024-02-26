module Fruit

open FruitTypes
open ProductTypes

type Fruit = private {
    Category: FruitCategory
} with
    interface IProduct with
        member this.Name = 
            match this.Category with
            | Fruit (ftype, quantity) -> sprintf "%d x %A" quantity ftype
        member this.Price =
            match this.Category with
            | Fruit (ftype, quantity) -> 
                let unitPrice = basePriceByType ftype
                float quantity * unitPrice  // Total price based on quantity

let createFruit ftype quantity = { Category = Fruit(ftype, quantity) } :> IProduct
