using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input a, b, c
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] values = new int[6];

            // All possible combinations
            values[0] = a + b * c;
            values[1] = a * (b + c);
            values[2] = a * b * c;
            values[3] = (a + b) * c;
            values[4] = a * b + c;
            values[5] = a - b - c;

            int maxValue = values[0];

            // Max value
            foreach (int i in values) 
            {
                if (i > maxValue)
                    maxValue = i;
            }

            Console.WriteLine(maxValue);
        }
    }
}