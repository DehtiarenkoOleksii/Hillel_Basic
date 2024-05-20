namespace Transport
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Objects of the derived class
            Car myCar = new Car("BMW", 180, 4);
            Bicycle myBicycle = new Bicycle("Comanche", 25, "Mountain");

            // Object of the base class
            Transport myTransport = new Transport("Bike", 270);

            PrintMovement(myCar);
            PrintMovement(myBicycle);
            PrintMovement(myTransport);

            //Delay
            Console.ReadKey();
        }

        public static void PrintMovement(Transport transport)
        {
            Console.WriteLine(transport.Move());
        }
    }
}
