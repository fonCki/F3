module Food

open ProductTypes
open FoodTypes

type Food = private {
    Category: FoodCategory
} with
    interface IProduct with
        member this.Name = 
            let sizeToString = function
                | Regular -> "Regular"
                | Medium -> "Medium"
                | Large -> "Large"
                | SuperSize -> "SuperSize"
            match this.Category with
            | Pizza (pi, s) -> sprintf "%s Pizza: %A" (sizeToString s) pi
            | Pasta (pa, s) -> sprintf "%s Pasta: %A" (sizeToString s) pa
            | Salad (sa, s) -> sprintf "%s Salad: %A" (sizeToString s) sa
            | Sandwich (sa, s) -> sprintf "%s Sandwich: %A" (sizeToString s) sa
            | Soup (so, s) -> sprintf "%s Soup: %A" (sizeToString s) so
        member this.Price =
            let basePrice = match this.Category with
                            | Pizza (_, s) | Pasta (_, s) | Salad (_, s) | Sandwich (_, s) | Soup (_, s) -> basePriceByCategory this.Category
            let size = match this.Category with
                       | Pizza (_, s) | Pasta (_, s) | Salad (_, s) | Sandwich (_, s) | Soup (_, s) -> s
            let multiplier = sizeMultiplier size
            basePrice * multiplier

let createFood category = { Category = category } :> IProduct