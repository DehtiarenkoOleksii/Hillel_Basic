namespace Students
{
    internal class Program
    {
        #region Task
        //У вас є список студентів з такими властивостями: Ім'я (Name), Оцінка (Grade) та Курс (Course). Вам потрібно вирішити наступні завдання, використовуючи LINQ:
        //Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
        //Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
        //Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
        //Підрахунок: Порахуйте кількість студентів на кожному курсі.
        //Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента, наприклад: "Ім'я: Олена, Оцінка: 95".
        //Будь ласка, реалізуйте ці завдання за допомогою LINQ в C# та виведіть результати.
        #endregion
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alex", Grade = 96, Course = 1 },
                new Student { Name = "Vova", Grade = 87, Course = 2 },
                new Student { Name = "Jane", Grade = 90, Course = 1 },
                new Student { Name = "Mary", Grade = 71, Course = 3 },
                new Student { Name = "Bill", Grade = 85, Course = 2 },
                new Student { Name = "Jack", Grade = 99, Course = 2 },
                new Student { Name = "Sara", Grade = 93, Course = 3 }
            };

            var highGradeStudents = FilterHighGradeStudents(students);
            highGradeStudents.Print("Students with grade more or equal 90:");

            var sortedStudents = SortStudentsByGradeDescending(students);
            sortedStudents.Print("Students sorted by grade, descending:");

            var groupedStudents = GroupStudentsByCourse(students);
            groupedStudents.PrintGrouped("Students, grouped by course:");

            var studentCounts = CountStudentsPerCourse(students);
            studentCounts.PrintCounts("Students count on every course:");

            var nameAndGradeList = ProjectNameAndGrade(students);
            nameAndGradeList.Print("Name and grade for every student:");

            // Delay
            Console.ReadKey();
        }

        //Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
        static List<Student> FilterHighGradeStudents(List<Student> students)
        {
            return students.Where(s => s.Grade >= 90).ToList();
        }

        //Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
        static List<Student> SortStudentsByGradeDescending(List<Student> students)
        {
            return students.OrderByDescending(s => s.Grade).ToList();
        }

        //Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
        static IEnumerable<IGrouping<int, Student>> GroupStudentsByCourse(List<Student> students)
        {
            return students.GroupBy(s => s.Course);
        }

        //Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента, наприклад: "Ім'я: Олена, Оцінка: 95".
        static IEnumerable<string> ProjectNameAndGrade(List<Student> students)
        {
            return students.Select(s => $"Name: {s.Name}, Grade: {s.Grade}").ToList();
        }

        static IEnumerable<(int Course, int Count)> CountStudentsPerCourse(List<Student> students)
        {
            return students.GroupBy(s => s.Course)
                           .Select(g => (Course: g.Key, Count: g.Count()));
        }
    }
}
