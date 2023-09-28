using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint1.Task7.V30.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                     5    3         5                    *");
            Console.WriteLine("*                           x     sinx  + x         y                     *");
            Console.WriteLine("*                 z =  x + e  +   ----------  +  ------                   *");
            Console.WriteLine("*                                      x            y                     *");
            Console.WriteLine("*                                     3            5                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ответ равен " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
