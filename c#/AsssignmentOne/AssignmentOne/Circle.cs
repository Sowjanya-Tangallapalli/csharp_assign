using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Circle
    {
        static void area()
        {
            double r, perimeter;
            double PI = 3.14;
            Console.WriteLine(" Radius of the circle :");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = (2 * PI * r);
            Console.WriteLine("Perimeter of Circle is: " + perimeter);
            double area = (PI * r * r);
            Console.WriteLine("Area of Circle is: " + area);
        }
        public static void Main()
        {
            area();
        }
    }
}
