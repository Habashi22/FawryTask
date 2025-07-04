# E-Commerce System

This is a simple console-based e-commerce system implemented in C#. The system models products (some of which may expire or require shipping), allows customers to add products to a cart, and perform checkout with proper validations.

---

## Features

- Define products with name, price, and quantity.
- Support expirable products (e.g., Cheese, Biscuits) with expiration dates.
- Support shippable products (e.g., TV, Cheese) with weight and shipping fees.
- Customers can add products to a cart with a quantity not exceeding available stock.
- Checkout process includes:
  - Validations for expired products and stock availability.
  - Calculation of order subtotal, shipping fees, total amount, and customer's remaining balance.
  - Error handling for empty carts, insufficient balance, and out-of-stock or expired products.
  - Shipping service that handles shippable items and prints shipment details.

---

## Project Structure

- **Product.cs**: Base class for products.
- **ExpirableProduct.cs**: Derived class for products with expiration.
- **ShippableProduct.cs**: Derived class implementing `IShippable` interface for products requiring shipping.
- **CartItem.cs**: Represents an item in the shopping cart.
- **Cart.cs**: Holds multiple `CartItem`s and provides subtotal and shipping fee calculations.
- **Customer.cs**: Represents a customer with a balance and cart; manages checkout process.
- **ShippingService.cs**: Static service that handles shipping of shippable items.
- **Program.cs**: Example usage demonstrating adding products to cart and checking out.

---

## Usage

1. Clone or download the repository.
2. Build the project in your preferred C# environment (e.g., Visual Studio, VS Code).
3. Run the program.
4. Observe the console output for shipment notice and checkout receipt.

---

## Example Output

** Shipment notice **
2x Cheese 400g
1x Biscuits 700g
Total package weight 1.1kg

** Checkout receipt **
2x Cheese 200
1x Biscuits 150
Subtotal 350
Shipping 30
Amount 380
Remaining Balance: 620
