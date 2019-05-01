using System;
using System.Collections;
using System.Linq;

namespace Exercise_43
{
    class _Point
    {
        static void Main(string[] args)
        {
            string userContinue = null;


            do
            {

                Console.WriteLine($"Hello User, enter two seperate numbers, one on each line:");
                Point pt = new Point();
                int xVal = pt.GetX();
                int yVal = pt.GetY();

                int calculateDistanceY = Convert.ToInt32(Math.Pow((yVal - 0), 2));
                int calculateDistanceX = Convert.ToInt32(Math.Pow((xVal - 0), 2));
                int calculateTotalDistance = Convert.ToInt32(Math.Sqrt(calculateDistanceX + calculateDistanceY));

                Console.WriteLine($"The coordinates you entered are ({xVal}, {yVal}). It has a distance of {calculateTotalDistance}.");
                Console.WriteLine($"Would you like to continue? (y/n)");
                string userExit = Console.ReadLine();
                if (userExit == "n")
                {
                    break;
                }
            } while (userContinue != "n");

            Console.ReadLine();
        }

    }
    class Point
    {
        private int xInput = Convert.ToInt32(Console.ReadLine());
        public void SetX(int x)
        {
            xInput = x;
        }
        public int GetX()
        {
            return xInput;
        }


        private int yInput = Convert.ToInt32(Console.ReadLine());
        public void SetY(int y)
        {
            yInput = y;
        }
        public int GetY()
        {
            return yInput;
        }


    }
}
