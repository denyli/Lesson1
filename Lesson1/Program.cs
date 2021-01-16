using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{

    // Ученик - Андрей Марачковский 
    class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            Console.WriteLine("Задача №1");

            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Рост: ");
            string growth = Console.ReadLine();
            Console.Write("Вес: ");
            string weight = Console.ReadLine();

            // склеивание    
            Console.WriteLine("Имя: " + name + ", фамилия: " + surname + ", возраст: " + age + ", рост: " + growth + ", вес: " + weight);

            // форматированный вывод    
            Console.WriteLine("Имя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}", name, surname, age, growth, weight);

            // вывод со знаком $
            Console.WriteLine($"Имя: {name}, фамилия: {surname}, возраст: {age}, рост: {growth}, вес: {weight}");

            Console.ReadLine();

            #endregion

            #region Task02
            Console.Clear();
            Console.WriteLine("Задача №2");
            Console.Write("Рост в метрах: ");
            string inputGrowth = Console.ReadLine();
            Console.Write("Вес в килограммах: ");
            string inputWeight = Console.ReadLine();

            double iGrowth = Convert.ToDouble(inputGrowth);
            int iWeight = Convert.ToInt32(inputWeight);
            double imt = iWeight / (iGrowth * iGrowth);

            Console.WriteLine("Ваш индекс массы тела (ИМТ): {0:F1}", imt);
            Console.ReadLine();
            #endregion

            #region Task03
            Console.Clear();
            Console.WriteLine("Задача №3");
            Console.Write("Введите координату точки x1:");
            string strX1 = Console.ReadLine();
            Console.Write("Введите координату точки y1:");
            string strY1 = Console.ReadLine();
            Console.Write("Введите координату точки x2:");
            string strX2 = Console.ReadLine();
            Console.Write("Введите координату точки y2:");
            string strY2 = Console.ReadLine();

            double x1 = Convert.ToInt32(strX1);
            double y1 = Convert.ToInt32(strY1);
            double x2 = Convert.ToInt32(strX2);
            double y2 = Convert.ToInt32(strY2);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Результат: {0:F2}", r);
            #endregion
        }
    }
}
