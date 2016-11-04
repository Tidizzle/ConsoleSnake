using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Move
    {
        //check for keypress -> 
        //Remove character from old add it to new ->
        //update board

        private int _StartX;
        private int _StartY;
        public int StartX
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
        public int StartY
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

        public void SetRndPosition()
        {
            Random rnd = new Random();
            int StartingX = rnd.Next(0, 39);
            int StartingY = rnd.Next(0, 19);

            this.StartX = StartingX;
            this.StartY = StartingY;
        }

        public void SetPosition(int x, int y)
        {
            this.StartX = x;
            this.StartY = y;
            Location.X = this.StartX;
            Location.Y = this.StartY;
        }

        public void GetKeyPress()
        {
            ConsoleKey getKey = Console.ReadKey().Key;
            string one = getKey.ToString();
            string keypress = one.ToLower();
            KeyPress = keypress;
        }

        private string _keypress;
        public string KeyPress
        {
            get
            {
                return _keypress;
            }
            set
            {
                _keypress = value;
            }
        }

        public void ProcessKeyPress(Grid name)
        {
            switch (KeyPress)
            {
                case "a":
                    int CurrX = Location.X;
                    Location.ChangeX(-1);
                    int NewX = Location.X;

                    if (NewX > 40 || NewX < 0)
                    {
                        NewX = CurrX;
                    }

                    name.array[CurrX, Location.Y] = "-";
                    name.array[NewX, Location.Y] = "X";
                    break;
                case "d":
                    CurrX = Location.X;
                    Location.ChangeX(1);
                    NewX = Location.X;

                    if (NewX > 40 || NewX < 0)
                    {
                        NewX = CurrX;
                    }

                    name.array[CurrX, Location.Y] = "-";
                    name.array[NewX, Location.Y] = "X";
                    break;
                case "s":
                    int CurrY = Location.Y;
                    Location.ChangeY(1);
                    int NewY = Location.Y;

                    if (NewY > 20 || NewY < 0)
                    {
                        NewY = CurrY;
                    }
                    name.array[Location.X, CurrY] = "-";
                    name.array[Location.X, NewY] = "X";
                    break;
                case "w":
                    CurrY = Location.Y;
                    Location.ChangeY(-1);
                    NewY = Location.Y;

                    if (NewY > 20 || NewY < 0)
                    {
                        NewY = CurrY;
                    }
                    name.array[Location.X, CurrY] = "-";
                    name.array[Location.X, NewY] = "X";
                    break;
            }
        }





    }
}
