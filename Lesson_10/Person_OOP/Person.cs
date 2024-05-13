using Person_OOP;

internal class Person
{
    private string name;
    private int age;
    private Gender gender = Gender.Not_Selected;

    // Constructor which get all info
    public Person(string name, int age, Gender gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }
    // Constructor which only name, age set like 0(default value) , gender is unkown
    public Person(string name)
    {
        this.name = name;
    }
    // Constructor which get name and age, gender is not selected
    public Person(string name, int age) : this(name)
    {
        this.age = age;
    }

    // Return Personal info in beautifull string
    public string GetPersonInfo()
    {
        return $"\nName: {name}\n" +
            $"Age: {age}\n" +
            $"Gender: {gender}";
    }
    // Display properties for class instance 

    public bool IsAdult()
    {
        return age >= 18;
    }

    // Method for changing name for desiring 
    public void ChangeName()
    {
        string answer;
        // loop intil user desire what he/she wants
        do
        {
            Console.WriteLine($"Do you want to change the name for {name}? (Y/N)");
            answer = Console.ReadLine().Trim().ToUpper();

            if (answer == "Y")
            {
                Console.WriteLine("Enter the new name:");
                string newName = Console.ReadLine();

                if (!string.IsNullOrEmpty(newName))
                {
                    name = newName;
                    Console.WriteLine($"Name changed to: {name}");
                    Console.WriteLine(GetPersonInfo());
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