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
            person.ChangeName();
        }

    }
}
