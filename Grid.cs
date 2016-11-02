using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Grid
    {
        public string[,] array = new string[40, 20];

        public Grid(string name,int x, int y)
        {
            


        }

        public void InitalizeArray(string character)
        {
            string chara = character;

            for(int x = 0; x < 40; x++)
            {
                array[x, 0] = chara; 


            }
        }
    }
}
