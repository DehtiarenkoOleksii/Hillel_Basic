namespace Filter_And_Sorting
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<Product> products = new List<Product>
        {
            new Product { Name = "Товар1", Price = 50 },
            new Product { Name = "Товар2", Price = 55 },
            new Product { Name = "Товар3", Price = 33 },
            new Product { Name = "Товар4", Price = 25 },
            new Product { Name = "Товар5", Price = 49.99m }
        };

            var filteredAndSortedProducts = products
                .Where(p => p.Price < 50)
                .OrderBy(p => p.Price);

            Console.WriteLine("Товари з ціною менше 50 гривень та відсортовані за зростанням ціни:");
            foreach (var product in filteredAndSortedProducts)
            {
                Console.WriteLine($"{product.Name}: {product.Price} грн");
            }
            //Delay
            Console.ReadKey();
        }
    }
}
