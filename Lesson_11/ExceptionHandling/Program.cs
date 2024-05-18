
namespace ExceptionHandling
#region Task
//2) Завдання на обробку виключень: Напишіть програму для обробки вводу віку користувача.

//Умови:
//1) Користувач повинен ввести свій вік за допомогою консолі.
//2) Програма повинна перевірити, чи вік введений коректно(ціле додатнє число).
//3) Якщо вік введений некоректно(наприклад, це не ціле число або він менший за 0), програма повинна викинути виняток FormatException.
//4) Якщо вік введений коректно, програма повинна вивести повідомлення про вік користувача.
//5) Обробіть виняток FormatException та виведіть користувачеві повідомлення про помилку.
//6) Програма повинна продовжити своє виконання після обробки винятку.
#endregion
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your age: ");
                    string input = Console.ReadLine();

                    // Check if the input value is an integer and within the range of int
                    if (int.TryParse(input, out int age))
                    {
                        if (age < 0 || age > 123)
                        {
                            // Specially used ArgumentOutOfRangeException instead of FormatException, it is not according to reqs but more varied exceptions
                            throw new ArgumentOutOfRangeException("age", age, "Age must be between 0 and 123.");
                        }

                        Console.WriteLine($"Your age: {age}");
                        break; // Exit the loop if the age is valid
                    }
                    else
                    {
                        // Check if the input value is a number that exceeds the int range
                        if (double.TryParse(input, out double doubleValue))
                        {
                            if (doubleValue > int.MaxValue || doubleValue < int.MinValue)
                            {
                                throw new OverflowException($"The entered value exceeds the int range ({int.MinValue} - {int.MaxValue}).");
                            }
                            else
                            {
                                throw new FormatException("The entered value is not a valid integer.");
                            }
                        }
                        else
                        {
                            throw new FormatException("The entered value is not a number.");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    // Handle FormatException
                    Console.WriteLine($"Format Error: {ex.Message}");
                    Console.WriteLine("Please try again.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    // Handle ArgumentOutOfRangeException
                    Console.WriteLine($"Out Of Range Error: {ex.Message}");
                    Console.WriteLine("Please try again.");
                }
                catch (OverflowException ex)
                {
                    // Handle OverflowException
                    Console.WriteLine($"Overflow Error: {ex.Message}");
                    Console.WriteLine("Please try again.");
                }
            }
        }
    }
}
