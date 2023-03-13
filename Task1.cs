using System;
namespace KPO_lab2_1
{
    public class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество двоичных чисел: ");
            int n = int.Parse(Console.ReadLine());

            string[] binaryNumbers = new string[n];

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} число в двоичном виде: ");
                binaryNumbers[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (CompareBinaryNumbers(binaryNumbers[j], binaryNumbers[j + 1]))
                    {
                        string temp = binaryNumbers[j];
                        binaryNumbers[j] = binaryNumbers[j + 1];
                        binaryNumbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(binaryNumbers[i]);
            }
        }
        public static bool CompareBinaryNumbers(string firstNumber, string secondNumber)
        {
            if (firstNumber.Length > secondNumber.Length)
            {
                return true;
            }
            else if (firstNumber.Length == secondNumber.Length)
            {
                for (int i = 0; i < firstNumber.Length; i++)
                {
                    if (int.Parse(firstNumber[i].ToString()) > int.Parse(secondNumber[i].ToString()))
                        return true;
                    if (int.Parse(firstNumber[i].ToString()) < int.Parse(secondNumber[i].ToString()))
                        return false;
                }
            }
            return false;
        }
    }
}
