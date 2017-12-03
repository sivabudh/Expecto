module Domain

type Sku = string
type Price = int
type Qty = int

type Product = {
    sku: Sku
    price: Price
}

type Event =
    | AddToBasket of Product * Qty