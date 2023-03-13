using System;

namespace KPO_lab2_3._26
{
    public class Program
    {
        public static string AmountOfAnyM(int sum)
        {
            Console.WriteLine($"Сумма: {sum}");
            int m1 = 0;
            int m2 = 0;
            int m4 = 0;
            int m8 = 0;
            int m16 = 0;
            int m32 = 0;
            int m64 = 0;

            if (sum / 64 != 0)
            {
                m64 = sum / 64;
                sum -= m64 * 64;
            }
            if (sum / 32 != 0)
            {
                m32 = sum / 32;
                sum -= m32 * 32;
            }
            if (sum / 16 != 0)
            {
                m16 = sum / 16;
                sum -= m16 * 16;
            }
            if (sum / 8 != 0)
            {
                m8 = sum / 8;
                sum -= m8 * 8;
            }
            if (sum / 4 != 0)
            {
                m4 = sum / 4;
                sum -= m4 * 4;
            }
            if (sum / 2 != 0)
            {
                m2 = sum / 2;
                sum -= m2 * 2;
            }

            m1 = sum;

            return ($"64: {m64}\n" +
                $"32: {m32}\n" +
                $"16: {m16}\n" +
                $"8: {m8}\n" +
                $"4: {m4}\n" +
                $"2: {m2}\n" +
                $"1: {m1}");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите сумму: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(AmountOfAnyM(n + i));
                Console.WriteLine();
            }
        }
    }
}
