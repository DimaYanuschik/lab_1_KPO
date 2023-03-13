using System;
using System.Diagnostics;

namespace KPO_lab2_2_rec
{
    public class Program
    {
        public static long FindNumber(int n)
        {
            if(n == 1) return 0;   
            if(n == 2) return 1;
            return FindNumber(n - 1) + FindNumber(n - 2);
        }


        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            Console.Write("Какое число Фибоначчи вы хотите узнать: ");
            int n = int.Parse(Console.ReadLine());

            timer.Start();

            long number = FindNumber(n);

            timer.Stop();

            Console.WriteLine(number);
            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}
