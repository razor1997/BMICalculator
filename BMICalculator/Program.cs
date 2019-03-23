using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myTime = DateTime.Now;
            float weight = 1;
            double height = 1;
            double BMI;
            Console.WriteLine("Podaj swoją masę", myTime.DayOfWeek);
            try
            {
                weight = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nie wczytano liczby");
            }
            Console.WriteLine("Podaj swój wzrost");
            try
            {
                height = int.Parse(Console.ReadLine());
                height = height / 100;
                height = Math.Pow(height, 2);
            }
            catch (Exception)
            {
                Console.WriteLine("Nie wczytano liczby");
            }
            BMI = weight / height;
            Console.WriteLine("Waga " + weight + "  Wzrost " + height + " BMI " + BMI);
            if (BMI < 16)
                Console.WriteLine("Wygłodzenie");
            if (BMI >= 16 && BMI < 17)
                Console.WriteLine("Wychudzenie");
            if (BMI >= 17 && BMI < 18.5)
                Console.WriteLine("Niedowaga");
            if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Waga prawidłowa");
            if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Nadwaga");
            if (BMI >= 30 && BMI < 35)
                Console.WriteLine("I stopień otyłości");
            if (BMI >= 35 && BMI < 40)
                Console.WriteLine("II stopień otyłości");
            if (BMI >= 40)
                Console.WriteLine("Otyłość skrajna");

            Console.ReadKey();
        }
    }
}
