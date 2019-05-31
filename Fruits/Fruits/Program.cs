using System;

namespace Fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FRUITS ARE AWESOME!!!");

            TropicalFruits TF1 = new TropicalFruits("Mangoo", 9, 2);
            TF1.fruitColor("yellow and orange");
            TropicalFruits TF2 = new TropicalFruits("Pineapple",7,9);
            TF2.fruitColor("golden yellow");


            Berries B1 = new Berries("Strawberry", 8, 3);
            B1.berryColor("red");
            Berries B2 = new Berries("BlueBerry", 4, 1);
            B2.berryColor("blue");

        }
    }
}
