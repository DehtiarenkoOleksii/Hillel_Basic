namespace BookInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = "Odyssey";
            string author = "Homer";
            string year = "8th century BC";
            float price = 65f;
            string BookInfo = string.Format(" Title = {0}\n Author = {1}\n Written = {2}\n Price = {3}$", bookName, author, year, price);
            Console.WriteLine(BookInfo);

            Console.ReadKey();
           
        }
    }
}
