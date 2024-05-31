namespace Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a shop
            Shop shop = new Shop();

            // Add products to the shop
            shop.AddProduct(new Product(1, "Apple", 10));
            shop.AddProduct(new Product(2, "Banana", 15.99m));
            shop.AddProduct(new Product(3, "Orange", 0.50m));

            // Try to add non uniqu id
            shop.AddProduct(new Product(3, "Pear", 0.50m));

            // Display products in the shop
            Console.WriteLine("Products in the shop: ");
            foreach (var product in shop.GetProductList())
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            // Create a cart
            Cart cart = new Cart();

            // Add products to the cart
            cart.AddToCart(shop.GetProductById(1));
            cart.AddToCart(shop.GetProductById(2));

            // Try to add product with unexisting ID
            cart.AddToCart(shop.GetProductById(5));

            // Display products in the cart
            Console.WriteLine("\nProducts in the cart:");
            foreach (var product in cart.GetCartProducts())
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            // Display total price of the cart
            Console.WriteLine($"\nTotal price of the cart: {cart.GetTotalPrice()}");

            // Remove a product from the cart
            cart.RemoveFromCart(1);

            // Display products in the cart after removal
            Console.WriteLine("\nProducts in the cart after removal:");
            foreach (var product in cart.GetCartProducts())
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            // Display total price of the cart after removal
            Console.WriteLine($"\nTotal price of the cart after removal: {cart.GetTotalPrice()}");
        }
    }
}
