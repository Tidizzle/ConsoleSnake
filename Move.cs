using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class Move
    {
        //check for keypress -> 
        //Remove character from old add it to new ->
        //update board

        private static int _StartX;
        private static int _StartY;
        public static int StartX
        {
            get
            {
                return _StartX;
            }
            set
            {
                _StartX = value;
            }
        }
        public static int StartY
        {
            get
            {
                return _StartY;
            }
            set
            {
                _StartY = value;
            }
        }

        public static void SetRndPosition()
        {
            Random rnd = new Random();
            int StartingX = rnd.Next(0, 39);
            int StartingY = rnd.Next(0, 19);

            Move.StartX = StartingX;
            Move.StartY = StartingY;
        }

        public static void SetPosition(int x, int y)
        {
            Move.StartX = x;
            Move.StartY = y;
        }

        public static void CheckKeyPress()
        {
            //var test = Console.ReadKey();
            //string test2 = test.ToString();
            //Console.WriteLine(test2);


            ConsoleKey test = Console.ReadKey().Key;

            Console.WriteLine();
            Console.WriteLine();
            string test2 = test.ToString();
            string test3 = test2.ToLower();
            Console.WriteLine(test3);
        }
    }
}
