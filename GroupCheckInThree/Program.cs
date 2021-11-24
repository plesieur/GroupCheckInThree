using System;

namespace GroupCheckInThree
{
    class Program
    {
        enum Color { White, Black };
        class Item
        {

            int _count;
            Color _color;

            public Item ()
            {
                _count = 0;
                _color = Color.Black;
            }
        }

        static void Main(string[] args)
        {
            Item Balloons = new Item();
            Item Balls = new Item();
            Item Marbles = new Item();
            Item Bicycles = new Item();
            Item Coats = new Item();

            int dummy = 12;

            Console.WriteLine("Hello, Class!");
            Console.WriteLine("I have {0} Balloons, {1} Balls, {2} Marbles and {3} Bicycles (plus {4} Coats)",dummy,dummy,dummy,dummy,dummy);

        }
    }
}
