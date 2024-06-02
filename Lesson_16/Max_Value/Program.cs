namespace Max_Value
{
    internal class Program
    {
        // Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.
        #region max value by index
        static void Main()
        {
            List<int> numbers = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };

            // Full list print
            Console.WriteLine("Full list:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var maxNumberWithIndex = numbers
                .Select((value, index) => new { Value = value, Index = index })
                .OrderByDescending(x => x.Index)
                .FirstOrDefault();

            // check for null
            if (maxNumberWithIndex != null)
            {
                Console.WriteLine($"Max value by index: {maxNumberWithIndex.Value}, Index: {maxNumberWithIndex.Index}");
            }
            //Delay
            Console.ReadKey();
        }
        #endregion
        #region max value for cases where we don't need index
        //static void Main()
        //{
        //    List<int> numbers = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };

        //    // check for null and empty
        //    if (numbers != null && numbers.Any())
        //    {

        //        int maxNumber = numbers.Max();
        //        Console.WriteLine("Max value: " + maxNumber);
        //    }
        //    else
        //    {
        //        Console.WriteLine("List is empty or doesn't contain numbers");
        //    }
        ////Delay
        //Console.ReadKey();
        //}
        #endregion
    }
}
