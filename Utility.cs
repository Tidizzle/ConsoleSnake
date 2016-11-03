using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class Utility
    {

        //create console no close functionality with custom messages
        public static void ConsoleClose(string type)
        {
            string TYPE = type.ToUpper();

            switch (TYPE)
            {
                case "MESSAGE":
                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to close. . .");
                    Console.ReadKey();
                    break;
                case "NONMESSAGE":
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
            }

            
        }
    }
}
