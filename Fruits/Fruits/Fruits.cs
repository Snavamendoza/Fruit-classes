using System;
using System.Collections.Generic;
using System.Text;

namespace Fruits
{
    public class Fruits
    {
        // properties
        public string _name { set; get; }

        public int _sweetnessLevel { set; get; }

        public Fruits(string Name, int SL)
        {
            _name = Name;
            _sweetnessLevel = SL;

            Console.WriteLine("This is a Fruit!");
        }
    }

    public class TropicalFruits : Fruits
    {
        // properties for just Tropical Fruits
        public int _acidLevel { set; get; }

        // constructor
        public TropicalFruits(string Name, int SL, int AL) : base(Name, SL)
        {
            _name = Name;
            _acidLevel = AL;
        }

        public void fruitColor(string FT)
        {
            Console.WriteLine("Your tropical fruit's color is {0}", FT);
            Console.WriteLine("Your tropical fruit's sweetness level is {0}", _sweetnessLevel);
            Console.WriteLine("The fruit's acid level is {0}", _acidLevel);
        }
    }

    public class Berries : Fruits
    {
        // properties of berries only

        public int _size { set; get; }

        // constructor 

        public Berries(string Name, int SL, int Size) : base(Name, SL)
        {
            _name = Name;
            _sweetnessLevel = SL;
            _size = Size;
        }
        public void berryColor(string col)
        {
            Console.WriteLine(" The berry's color is {0}", col);
            Console.WriteLine("The berry's sweetness level is {0}", _sweetnessLevel);
            Console.WriteLine("The berries size is {0}", _size);
        }

    }
}

