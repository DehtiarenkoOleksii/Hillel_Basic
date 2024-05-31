using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Shop
{
    public class Cart
    {
        private Dictionary<int, Product> cartItems = new Dictionary<int, Product>(); // Dictionary of products in the cart with Id as the key

        // Add product to the cart
        public void AddToCart(Product product)
        {
            // validation for adding product
            if (product != null)
            {
                if (!cartItems.ContainsKey(product.Id))
                {
                    cartItems[product.Id] = product;
                }
                else
                {
                    Console.WriteLine($"Product with Id {product.Id} is already in the cart.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        // Remove product from cart by its ID
        public void RemoveFromCart(int productId)
        {
            // Check ID existing
            if (cartItems.ContainsKey(productId))
            {
                cartItems.Remove(productId);
            }
            else
            {
                Console.WriteLine($"Product with Id {productId} not found in the cart.");
            }
        }

        public List<Product> GetCartProducts()
        {
            return cartItems.Values.ToList();
        }

        public decimal GetTotalPrice()
        {
            return cartItems.Values.Sum(p => p.Price);
        }
    }
}
