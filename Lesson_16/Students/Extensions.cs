using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public static class Extensions
    {
        /// <summary>
        /// Фільтрація: Знайти усіх студентів, які мають оцінку більше або рівну 90
        /// Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
        /// </summary>
        public static void Print(this List<Student> students, string header)
        {
            Console.WriteLine(header);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}: {student.Grade}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
        /// </summary>
        public static void PrintGrouped(this IEnumerable<IGrouping<int, Student>> groupedStudents, string header)
        {
            Console.WriteLine(header);
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Course {group.Key}:");
                foreach (var student in group)
                {
                    Console.WriteLine($"  {student.Name}: {student.Grade}");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Підрахунок: Порахуйте кількість студентів на кожному курсі.
        /// </summary>
        public static void PrintCounts(this IEnumerable<(int Course, int Count)> counts, string header)
        {
            Console.WriteLine(header);
            foreach (var (Course, Count) in counts)
            {
                Console.WriteLine($"Course {Course}: {Count} students");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента, наприклад: "Ім'я: Олена, Оцінка: 95".
        /// </summary>
        public static void Print(this IEnumerable<string> list, string header)
        {
            Console.WriteLine(header);
            foreach (var entry in list)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
        }
    }
}
