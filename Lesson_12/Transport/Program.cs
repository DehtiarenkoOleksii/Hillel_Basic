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

            // Object of a derived class is created by changing the base class
            Transport MyCar2 = new Car("Opel", 120, 5);

            PrintMovement(myCar);
            PrintMovement(myBicycle);
            PrintMovement(myTransport);
            PrintMovement(MyCar2);

            //Delay
            Console.ReadKey();
        }

        public static void PrintMovement(Transport transport)
        {
            Console.WriteLine(transport.Move());
        }
    }
}
