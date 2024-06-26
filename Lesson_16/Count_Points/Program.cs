﻿namespace Count_Points
{
    internal class Program
    {
        // Підрахунок: Дано список оцінок студентів {85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
        static void Main()
        {
            List<int> marks = new List<int> { 85, 92, 78, 95, 88, 90 };

            // Full list print
            Console.Write("Full list: ");
            foreach (var mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();

            int count = marks.Count(m => m > 90);

            Console.WriteLine("Counts students which got more than 90 points " + count);

            //Delay
            Console.ReadKey();
        }
    }
}
