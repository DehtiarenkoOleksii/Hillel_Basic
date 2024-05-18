using System;
using System.Xml.Linq;

namespace Person_OOP
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jane", 17, Gender.Female);
            Person person2 = new Person("John");
            Person person3 = new Person("Alex", 36);

            PrintDetails(person1);           
            PrintDetails(person2);          
            PrintDetails(person3);

        }
        // Print info about adulting
        public static void DisplayAdult(Person person)
        {
            Console.WriteLine("Person is adult - " + person.IsAdult() + "\n");
        }
        // Print FullInfo for person and opportunity to change name
        public static void PrintDetails(Person person)
        {
            Console.WriteLine(person.GetPersonInfo());
            DisplayAdult(person);
            ChangeName(person);
        }
        public static void ChangeName(Person person)
        {
            string answer;
            // loop until user decides what they want
            do
            {
                Console.WriteLine($"Do you want to change the name for {person.GetName()}? (Y/N)");
                answer = Console.ReadLine().Trim().ToUpper();

                if (answer == "Y")
                {
                    Console.WriteLine("Enter the new name:");
                    string newName = Console.ReadLine();

                    if (!string.IsNullOrEmpty(newName))
                    {
                        person.SetName(newName);
                        Console.WriteLine($"Name changed to: {person.GetName()}");
                        Console.WriteLine(person.GetPersonInfo());
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The name cannot be empty.");
                    }
                }
                else if (answer != "N")
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }
            } while (answer != "N");
        }

    }
}
