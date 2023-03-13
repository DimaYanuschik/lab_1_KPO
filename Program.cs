using System;

namespace KPO_lab2_4._26
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество марок авто: ");
            int carAmount = int.Parse(Console.ReadLine());

            int[] cars = new int[carAmount];

            for (int i = 0; i < carAmount; i++)
            {
                Console.Write($"Стоимость {i + 1} марки авто(>$5000): ");
                cars[i] = int.Parse(Console.ReadLine());
                if (cars[i] <= 5000)
                {
                    i--;
                    Console.WriteLine("Стоимость авто должна привышать $5000");
                }

            }

            Console.WriteLine();

            Console.Write("Введите количество марок мотоциклов: ");
            int motoAmount = int.Parse(Console.ReadLine());

            int[] motos = new int[motoAmount];

            for (int i = 0; i < motoAmount; i++)
            {
                Console.Write($"Стоимость {i + 1} марки мотоцикла(<=$5000): ");
                motos[i] = int.Parse(Console.ReadLine());
                if (motos[i] > 5000)
                {
                    i--;
                    Console.WriteLine("Стоимость мотоцикла не должна привышать $5000");
                }
            }

            int totalCarsCost = 0;
            int totalMotosCost = 0;

            for (int i = 0; i < carAmount; i++)
                totalCarsCost += cars[i];

            for (int i = 0; i < motoAmount; i++)
                totalMotosCost += motos[i];

            float averageCarCost = totalCarsCost / (float)carAmount;
            float averageMotoCost = totalMotosCost / (float)motoAmount;

            Console.WriteLine($"Средняя стоимаость авто: {averageCarCost}");
            Console.WriteLine($"Средняя стоимость мотоцика: {averageMotoCost}");

            Console.WriteLine();

            Console.WriteLine(IsCorrect(averageCarCost, averageMotoCost) ? "Верно" : "Неверно");
        }

        public static bool IsCorrect(float averageCarCost, float averageMotoCost)
        {
            if (averageCarCost / 3.0f > averageMotoCost)
                return true;
            else
                return false;
        }
    }
}
