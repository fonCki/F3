module FruitTypes

type FruitType = Apple | Orange | Banana | Grape | Mango

type FruitCategory =
    | Fruit of FruitType * int  // The int represents the quantity

let basePriceByType = function
    | Apple -> 0.5
    | Orange -> 0.6
    | Banana -> 0.3
    | Grape -> 0.8
    | Mango -> 1.0
