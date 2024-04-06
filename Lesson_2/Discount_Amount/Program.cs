namespace Discount_Amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort price = 120;
            byte discount = 10;
            decimal sale = (decimal)price/100*discount;

            if (discount > 100)
                Console.WriteLine("discount should be less then 100");

            else
                Console.WriteLine($"You will save {sale} dollars");

            Console.ReadKey();

        }
    }
}
