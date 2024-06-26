﻿namespace Transport
{
    #region Task
    //Ваша мета - створити ієрархію класів для обробки транспортних засобів: автомобілів та велосипедів.Вам потрібно використовувати успадкування та конструктори з оператором base.
    //Створіть базовий клас Транспорт, який містить поля для назви транспортного засобу(Назва) та максимальної швидкості(МаксимальнаШвидкість).
    //Створіть похідний клас Автомобіль, який успадковує Транспорт.Додайте до класу Автомобіль додаткове поле КількістьДверей.
    //Створіть конструктор для класу Автомобіль, який приймає аргументи для ініціалізації Назви, МаксимальноїШвидкості та КількостіДверей,
    //і викликає конструктор базового класу з використанням оператора base.
    //Створіть похідний клас Велосипед, який успадковує Транспорт.Додайте до класу Велосипед додаткове поле ТипВелосипеда.
    //Створіть конструктор для класу Велосипед, який приймає аргументи для ініціалізації Назви, МаксимальноїШвидкості та ТипуВелосипеда,
    //і викликає конструктор базового класу з використанням оператора base.
    //Створіть об'єкти класу Автомобіль та Велосипед, ініціалізуйте їх поля і виведіть інформацію про ці транспортні засоби на консоль.
    //Створіть метод Move, використайте техніку virtual/override.

    //Пам'ятайте про використання конструкторів з оператором base для передачі аргументів до базового класу та про роботу з транспортними засобами.
    #endregion
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
