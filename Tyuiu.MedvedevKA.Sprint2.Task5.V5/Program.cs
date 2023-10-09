using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.MedvedevKA.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                          *");
            Console.WriteLine("* Тема: Оператор switch                                                                                              *");
            Console.WriteLine("* Задание #5                                                                                                         *");
            Console.WriteLine("* Вариант #5                                                                                                         *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.        *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11,     *");
            Console.WriteLine("* «даме» — 12, «королю» — 13, «тузу» — 14.                                                                           *");
            Console.WriteLine("* Порядковые номера остальных карт соответствуют их названиям («шестерка», «девятка» и т. п.).                       *");
            Console.WriteLine("* По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.                            *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Введите номер карты: ");
            int numCard = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numCard < 6) || (numCard > 14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это карта: " + ds.FindCardValue(numCard);
            }
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
