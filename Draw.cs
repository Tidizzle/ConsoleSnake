using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    static class Draw 
    {

        //create private member variables and properties
        private static int row;
        private static int column;
        private static int counter3;

        public static int Row
        {
            get
            {
                return row;
            }

            set
            {
                row = value;
            }
        }
        public static int Column
        {
            get
            {
                return column;
            }

            set
            {
                column = value;
            }
        }
        public static int Counter3
        {
            get
            {
                return counter3;
            }

            set
            {
                counter3 = value;
            }
        }

        public static int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        private static int type;


        //draw characters from array to console
        public static void DrawGrid(Grid name)
        {
            Console.Clear();
            Row = 0;
            Column = 0;
            Counter3 = 1;
            Type = 1;

            //types: 1 = Char; 2 = return 3 = 
            for(int counter = 0; counter < 820; counter++)
            {
                if (Row >= 20)
                {
                    Row = 1;
                    Type = 2;
                }

                if (Column >= 40)
                {
                    column = 0;
                    Type = 2;
                }

                switch (Type)
                {
                    case 1:
                        Console.Write(name.array[Column,Row]);
                        Column += 1;
                        break;
                    case 2:
                        Console.WriteLine();
                        Row += 1;
                        Type = 1;
                        break;
                }
            }
        }

    }
}
