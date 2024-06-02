namespace Delete_Duplicates
{
    internal class Program
    {
        // Видалення дублікатів: Дано список рядків: {"А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<string> strings = new List<string> { "А", "Б", "В", "А", "Г", "В" };

            // Full list print
            Console.WriteLine("Повний список рядків:");
            foreach (var str in strings)
            {
                Console.Write(str + ", ");
            }
            Console.WriteLine();

            var uniqueStrings = strings.Distinct();

            Console.WriteLine("Унікальні рядки:");
            foreach (var str in uniqueStrings)
            {
                Console.Write(str + ", ");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
