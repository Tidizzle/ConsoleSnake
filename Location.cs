using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class Location
    {
        
        //Create Private Member variables
        private static int _x;
        private static int _y;

        //Create Properties for read/write access
        public static int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public static int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }


        //Create Methods for retrieving x and y coords

        public static int getX()
        {
            return X;
        }

        public static int getY()
        {
            return Y;
        }

        //create methods for changing x and y coords

        public static void ChangeX(int xChange)
        {
            int xC = xChange;
            int CurrX = X;

            int newCoord = CurrX + xC;
            X = newCoord;
        }

        public static void ChangeY(int yChange)
        {
            int yC = yChange;
            int currY = Y;

            int newCoord = currY + yC;
            Y = newCoord;
        }

        public static void SetX(int newX)
        {
            X = newX;
        }

        public static void SetY(int newY)
        {
            Y = newY;
        }

        //Set Custom starting coordinantes 
        public static void InitializeCoords(int y, int x)
        {
            X = x;
            Y = y;
        }

        //set default coordinantes
        public static void InitializeCoords()
        {
            X = 0;
            Y = 0;
        }


    }
}
