using System;

// Абстрактний клас Vehicle
public abstract class Vehicle
{
    // Властивості для задання та отримання ціни, швидкості та року випуску
    public decimal Price { get; set; }
    public int Speed { get; set; }
    public int Year { get; set; }

    // Абстрактний метод для отримання динамічних характеристик
    public abstract void GetDynamicCharacteristics();
}

// Клас Plain, що успадковується від Vehicle
public class Plain : Vehicle
{
    // Висота літака
    public int Altitude { get; set; }

    // Реалізація методу GetDynamicCharacteristics для виводу висоти
    public override void GetDynamicCharacteristics()
    {
        Console.WriteLine($"Altitude: {Altitude} feet");
    }
}

// Клас Car, що успадковується від Vehicle
public class Car : Vehicle
{
    // Реалізація методу GetDynamicCharacteristics для виводу загальної інформації
    public override void GetDynamicCharacteristics()
    {
        Console.WriteLine("This is a car");
    }
}

// Клас Ship, що успадковується від Vehicle
public class Ship : Vehicle
{
    // Кількість пасажирів та порт приписки корабля
    public int Passengers { get; set; }
    public string Port { get; set; }

    // Реалізація методу GetDynamicCharacteristics для виводу кількості пасажирів та порту
    public override void GetDynamicCharacteristics()
    {
        Console.WriteLine($"Passengers: {Passengers}");
        Console.WriteLine($"Port: {Port}");
    }
}

// Головний клас програми
class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів класів Plain, Car та Ship
        Plain plain = new Plain() { Price = 1000000, Speed = 500, Year = 2020, Altitude = 35000 };
        Car car = new Car() { Price = 50000, Speed = 120, Year = 2015 };
        Ship ship = new Ship() { Price = 2000000, Speed = 50, Year = 2018, Passengers = 1000, Port = "New York" };

        // Вивід динамічних характеристик кожного транспортного засобу за допомогою методу GetDynamicCharacteristics
        Console.WriteLine("Plain:");
        plain.GetDynamicCharacteristics();
        Console.WriteLine("Car:");
        car.GetDynamicCharacteristics();
        Console.WriteLine("Ship:");
        ship.GetDynamicCharacteristics();

        Console.ReadLine();
    }
}
