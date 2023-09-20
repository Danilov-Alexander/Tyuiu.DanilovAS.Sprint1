using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task3.V8
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
            Console.WriteLine("* (Процентная ставка (% годовых) и время хранения (дней) -                *");
            Console.WriteLine("* задаются во время работы программы.)                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Величина вклада  = 2500 рублей");
            Console.Write("Введите процентную ставку(годовых): ");
            double procent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Процентная ставка(годовых) = " + procent + " %");

            Console.Write("Введите срок вклада: ");
            double timeDays = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Срок вклада = " + timeDays + " дней");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма по окончанию вклада = " + ds.IncomeAmount(procent, timeDays) + " рублей.");
            Console.ReadKey();


        }
    }
}
