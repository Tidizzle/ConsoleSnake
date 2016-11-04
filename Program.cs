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
            
            Console.SetWindowSize(41, 23);
            Console.Title = "Console Snake";

            Move move = new Move();
            Grid board = new Grid(40, 20);
            board.InitalizeArray("-");
            move.SetRndPosition();
            Draw.DrawGrid(board);

            Draw.SetChar(move.StartX, move.StartY, board);
            Draw.DrawGrid(board);

            int i = 0;

           while(i < 9999)
            {
                move.GetKeyPress();
                move.ProcessKeyPress(board);
                Draw.DrawGrid(board);
                i++;
            }

  
           // Move.GetKeyPress();
            Utility.ConsoleClose("NONMESSAGE");
        }
    }
}
