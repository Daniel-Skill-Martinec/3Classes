using System;

namespace _3Classes
{
    class Car
    {
        string color = "Pink with Black Accents";
        string Accessories = "Spoiler and Foglights";
        int maxSpeed = 200;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.Accessories);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}
