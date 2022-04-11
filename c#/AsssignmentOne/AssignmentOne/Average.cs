using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Average
    {
        public static void Main()
        {
            //float average;
            int[] Marks = new int[5];
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write($"Enter array {i} value: ");
                Marks[i] = Convert.ToInt16(Console.ReadLine());
            }
            float sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }
            float average = sum / Marks.Length;
            Console.WriteLine("Students marks average is:" + average);
            //Console.ReadLine();
            int maxValue = Marks.Max();
            Console.WriteLine("Maximum number is: " + maxValue);



        }
    }
}
