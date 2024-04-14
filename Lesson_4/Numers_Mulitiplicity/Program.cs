
namespace Numers_Mulitiplicity
{
    internal class Program
    {
        // Напишіть програму, яка приймає від користувача число від 1 до 100.
        // При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz.
        // Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz. Завдання може здатися очевидним, але потрібно отримати найбільш просте та красиве рішення.
        static void Main(string[] args)
        {
            Console.Write("Enter number from 1 to 100 : ");
            int number = Parse(Console.ReadLine());

            // Checking mulitiplicity by 3,5,15
            string mulitiplicityResult = Mulitiplicity(number);
            Console.WriteLine(mulitiplicityResult);

            //Delay
            Console.ReadKey();
        }
        static int Parse(string input)
        {           
            return int.Parse(input);
        }
       

    static string Mulitiplicity(int number) 
        {
            string result;
            if (number > 0 && number < 101)
            {
                //// Variant1 Mathematic if
                //if (number % 3 == 0 || number % 5 == 0) 
                //{
                //    if (number % 15 == 0)
                //    {
                //        return "FizzBuzz";
                //    }
                //    else
                //    {
                //        if (number % 3 == 0)
                //            return "Fizz";
                //        else
                //            return "Buzz";
                //    }
                //}
                //else 
                //{
                //    return "Entered number is not mulitiplicity by 3,5,15";
                //}

                //// Variant1 Mathematic else if
                //if (number % 3 == 0) 
                //{
                //    if (number % 5 == 0)
                //        return "FizzBuzz";
                //    else
                //        return "Fizz";
                //}
                //else if (number % 5 == 0)
                //{
                //    if (number % 5 == 0)
                //        return "FizzBuzz";
                //    else
                //        return "Buzz";
                //}
                //return "Entered number is not mulitiplicity by 3,5,15";


                // Variant 3 The Best aproach for reqs))) message for case when entered number is not mulitiplicity by 3,5,15 was absent in requirements so it's absent here
                if (number % 3 == 0)
                    result = "Fizz";
                else
                    result = "";
                if (number % 5 == 0)
                    result = result + "Buzz";
                return result;


            }


            else
            {
                return result = $"Entered number \"{number}\" is not in range 1:100";
            }
        }
    }
}
