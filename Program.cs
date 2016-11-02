using System;
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

            Grid new1 = new Grid("New1", 40, 20);

            new1.InitalizeArray("X");
            /*
            Console.WriteLine(new1.array[0, 0]);
            Console.WriteLine(new1.array[1, 0]);
            Console.WriteLine(new1.array[2, 0]);
            Console.WriteLine(new1.array[3, 0]);
            Console.WriteLine(new1.array[4, 0]);
            Console.WriteLine(new1.array[5, 0]);
            Console.WriteLine(new1.array[6, 0]);
            Console.WriteLine(new1.array[7, 0]);
            Console.WriteLine(new1.array[8, 0]);
            Console.WriteLine(new1.array[9, 0]);
            Console.WriteLine(new1.array[10, 0]);
            Console.WriteLine(new1.array[11, 0]);
            */
            
            foreach (string element in new1.array)
            {
                Console.WriteLine(element);
            }    
    
    
        }
    }
}
