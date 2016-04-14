using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x1 = 1;
            int y1 = 2;
            string sym1 = "q";
            int x2 = 10;
            int y2 = 11;
            string sym2 = "t";
            */
            Point p1 = new Point();
            p1.x = 6;
            p1.y = 2;
            p1.symbol = "y";

            p1.Draw();
            Console.ReadLine();
        }
        
    }
}
