module Drink

open DrinkTypes
open ProductTypes // Assuming this module is defined in another file with IProduct definition.

type Drink = private {
    Category: DrinkCategory
} with
    interface IProduct with
        member this.Name = 
            let sizeToString = function
                | Tall -> "Tall"
                | Grande -> "Grande"
                | Venti -> "Venti"
                | Trenta -> "Trenta"
            match this.Category with
            | Coffee (c, s) -> sprintf "%s Coffee: %A" (sizeToString s) c
            | Tea (t, s) -> sprintf "%s Tea: %A" (sizeToString s) t
            | Juice (j, s) -> sprintf "%s Juice: %A" (sizeToString s) j
            | Smoothie (sm, s) -> sprintf "%s Smoothie: %A" (sizeToString s) sm
            | Milk (m, s) -> sprintf "%s Milk: %A" (sizeToString s) m
            | Other (o, s) -> sprintf "%s Other: %A" (sizeToString s) o
        member this.Price = 
            let getSize = function
                | Coffee (_, size) | Tea (_, size) | Juice (_, size) | Smoothie (_, size) | Milk (_, size) | Other (_, size) -> size
            let basePrice = basePriceByCategory this.Category
            let size = getSize this.Category
            let multiplier = sizeMultiplier size
            basePrice * multiplier

let createDrink category = { Category = category } :> IProduct