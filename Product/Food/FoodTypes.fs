module FoodTypes

type FoodSize = Regular | Medium | Large | SuperSize

type PizzaType = Cheese | Pepperoni | Veggie | MeatLovers
type PastaType = Spaghetti | Fettuccine | Penne | Ravioli
type SaladType = Caesar | Greek | Garden | Caprese
type SandwichType = Turkey | Ham | RoastBeef | Veggie
type SoupType = Tomato | ChickenNoodle | Minestrone | ClamChowder

type FoodCategory =
    | Pizza of PizzaType * FoodSize
    | Pasta of PastaType * FoodSize
    | Salad of SaladType * FoodSize
    | Sandwich of SandwichType * FoodSize
    | Soup of SoupType * FoodSize

let basePriceByCategory = function
    | Pizza _ -> 6.0
    | Pasta _ -> 5.5
    | Salad _ -> 4.0
    | Sandwich _ -> 5.0
    | Soup _ -> 3.5

let sizeMultiplier = function
    | Regular -> 1.0  // Standard price
    | Medium -> 1.2 // 20% more
    | Large -> 1.5  // 50% more
    | SuperSize -> 2.0  // Double the price of small
