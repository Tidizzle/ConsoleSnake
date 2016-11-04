using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Grid
    {

        //Create private member variables and properites
        private int _gridX;
        private int _gridY;
        private string _gridName;

        public int gridX
        {
            get
            {
                return _gridX;
            }
            set
            {
                _gridX = value;
            }
        }
        public int gridY
        {
            get
            {
                return _gridY;
            }
            set
            {
                _gridY = value;
            }
        }
        public string gridName
        {
            get
            {
                return _gridName;
            }
            set
            {
                _gridName = value;
            }
        }


        //create constructor
        public Grid(int x, int y)
        {
            gridX = x;
            gridY = y;  
        }


        //create array for storing characters
        public string[,] array = new string[40, 20];


        private string character;
        public string Character
        {
            get
            {
                return character;
            }
            set
            {
                character = value;
            }
        }

        //initialize array with character supplied
        public void InitalizeArray(string character)
        {
            string chara = character;
            Character = character;

            for(int x = 0; x < 40; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    array[x, y] = chara;
                }
            }
        }
    }
}
