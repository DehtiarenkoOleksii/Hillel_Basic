using System;

namespace Password_Validation
{
    internal class Program
    // 1) Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений.
    // Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //// Variant 1  (While) everything in main method, correctt password stay in while syntax condition
            //    Console.Write("Введіть пароль : ");
            //    string message = Console.ReadLine();
            //    while (message != "root") 
            //    {
            //        Console.WriteLine("Неправильний пароль!");
            //        Console.Write("\nВведіть пароль : ");
            //        message = Console.ReadLine();
            //    }
            //    Console.WriteLine("Успіх");
            //    //Delay
            //    Console.ReadKey();



            // Variant 2 with (do while) with separate method and correct password is variable
            string password = "root";
            ValidatePassword(password);

            //Delay
            Console.ReadKey(); 
        }
        static void ValidatePassword (string password) 
        {
            string inputPassword;
            do 
            {
                Console.Write("\nВведіть пароль : ");
                inputPassword = Console.ReadLine();

                if (inputPassword != password)
                {
                    Console.WriteLine("Неправильний пароль!");
                }
                    
            } 
            while (inputPassword != password);
            Console.WriteLine("Успіх");
            
            
        }
    }
}
