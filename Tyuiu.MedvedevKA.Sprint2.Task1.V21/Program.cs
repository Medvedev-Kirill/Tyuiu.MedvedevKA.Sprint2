using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint2.Task1.V21.Lib;

namespace Tyuiu.MedvedevKA.Sprint2.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                            *");
            Console.WriteLine("* Тема: Логические операции                                                                                            *");
            Console.WriteLine("* Задание #1                                                                                                           *");
            Console.WriteLine("* Вариант #21                                                                                                          *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                  *");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                             *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,                 *");
            Console.WriteLine("* но использовать один раз в выражении)                                                                                *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),                        *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность(массив):                              *");
            Console.WriteLine("* (False, False, False, False, True, False), при a = 696, b = 987, c = 696, d = 155                                    *");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                     *");
            Console.WriteLine("************************************************************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                           *");
            Console.WriteLine("************************************************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
