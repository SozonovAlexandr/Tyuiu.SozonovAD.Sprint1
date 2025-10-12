using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SozonovAD.Sprint1.Task3.V16.Lib;
namespace Tyuiu.SozonovAD.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Созонов А. Д. | ПКТ6-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Созонов Александр Дмитриевич | ПКТ6-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x1, x2;
            Console.WriteLine("Введите значение x1:");
            x1 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x2:");
            x2 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Приведённое квадратное уравнение: x^2 + ({ds.CoeffOfQuadraticEquation(x1, x2)})*x + ({x1 * x2}) = 0");
            Console.ReadLine();
        }
    }
}
