using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// ЗАДАНИЕ
// Написать программу из операций сравнений (==, !=, <, >, <=, >=,
// последовательность можно чередовать, но использовать один раз в выражении)
// и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
// и а также арифметических выражений, которая вернет логическую последовательность(массив): (False, False, False, False, True, False),
// при a = 696, b = 987, c = 696, d = 155

namespace Tyuiu.MedvedevKA.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {

            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a + 5 > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a + 5 > b) && (c < d);
            res[4] = !res[0];
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
