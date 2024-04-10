namespace Circle_Area
{
    internal class Program
    {
        // Користувач вводить радіус круга.Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат. 
        static void Main(string[] args)
        {
            int radius;
            Console.Write("Enter radius of the circle: ");
            string? input1 = Console.ReadLine();
            radius = int.Parse(input1);
            if (radius < 0 )
            Console.WriteLine("The radius should be > 0");
            else
            {
                // S = PI × r2                
                double area = (Math.PI) * Math.Pow(radius, 2);
                
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                // Round to 2 digits after coma for better user expirience
                Console.WriteLine($"Area of the circle ≈ {Math.Round(area, 2)}");


            }
            //Delay
            Console.ReadKey();
        }
    }
}
