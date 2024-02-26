module DrinkTypes

type DrinkSize = Tall | Grande | Venti | Trenta

type CoffeeType = Espresso | Latte | Americano | Mocha | Cappuccino
type TeaType = Green | Black | Herbal | Chai
type JuiceType = Orange | Apple | Mango | Pineapple | Cranberry
type SmoothieType = Berry | Tropical | Chocolate 
type MilkType = Whole | Skim | Almond | Soy
type OtherType = Water | Soda | Lemonade | IcedTea

type DrinkCategory =
    | Coffee of CoffeeType * DrinkSize
    | Tea of TeaType * DrinkSize
    | Juice of JuiceType * DrinkSize
    | Smoothie of SmoothieType * DrinkSize
    | Milk of MilkType * DrinkSize
    | Other of OtherType * DrinkSize

let basePriceByCategory = function
    | Coffee _ -> 2.0
    | Tea _ -> 1.5
    | Juice _ -> 1.0
    | Smoothie _ -> 2.5
    | Milk _ -> 1.2
    | Other _ -> 0.8

let sizeMultiplier = function
    | Tall -> 1.0  // Standard price
    | Grande -> 1.2 // 20% more
    | Venti -> 1.5  // 50% more
    | Trenta -> 2.0  // Double the price of small
