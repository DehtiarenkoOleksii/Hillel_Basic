using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Shop
{
    public class Shop
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        // Add a product to shop
        public void AddProduct(Product product)
        {
            // Check for unique ID
            if (!products.ContainsKey(product.Id))
            {
                products[product.Id] = product;
            }
            else
            {
                Console.WriteLine($"Product with Id {product.Id} already exists in the shop.");
            }
        }

        // Delete product from shop
        public void RemoveProduct(int productId)
        {
            // Check ID existing
            if (products.ContainsKey(productId))
            {
                products.Remove(productId);
            }
            else
            {
                Console.WriteLine($"Product with Id {productId} not found in the shop.");
            }
        }
       
        public Product GetProductById(int productId)
        {

                // Check ID existing 
                if (products.TryGetValue(productId, out var product))
                {
                    return product;
                }
                else
                {
                    // If  product is not found, return null
                    Console.WriteLine($"\nProduct with Id {productId} not found.");
                    return null;
                }


        }

        public List<Product> GetProductList()
        {
            return products.Values.ToList();
        }
    }
}
