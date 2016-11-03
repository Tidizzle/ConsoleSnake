using System;
using ConsoleSnake;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            //GRID 40x20
            /*
            Console.SetWindowSize(41, 23);
            Console.Title = "Console Snake";

            Grid board = new Grid(40, 20);
            board.InitalizeArray("-");
            Draw.DrawGrid(board);

            Move.SetRndPosition();

            board.array[Move.StartX, Move.StartY] = "X";
            Draw.DrawGrid(board);
            */

            Move.CheckKeyPress();
            Utility.ConsoleClose("NONMESSAGE");
        }
    }
}
