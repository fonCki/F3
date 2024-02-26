module Program

open ProductTypes

//open Food
open FoodTypes
open Food

//open Drinks
open DrinkTypes
open Drink

//open Fruit
open FruitTypes
open Fruit


// Creating drinks 

let espresso2 = createDrink (Coffee (Espresso, Tall))
let greenTea = createDrink (Tea (Green, Grande))

// Creating food 

let pizza1 = createFood (Pizza (Cheese, Regular))
let pasta1 = createFood (Pasta (Spaghetti, SuperSize))

// Creating fruit
let bananaOrder = createFruit Banana 4
let orangeOrder = createFruit Orange 3

// Function to print product information
let printProductInfo (product: IProduct) =
    printfn "Product: %s, Price: $%.2f" product.Name product.Price

// Creating a list of mixed products (drinks and food)
let products: IProduct list = [espresso2; greenTea; pizza1; pasta1; bananaOrder; orangeOrder]

// Printing information for each product in the list
products |> List.iter printProductInfo
