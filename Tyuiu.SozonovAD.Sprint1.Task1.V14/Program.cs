using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SozonovAD.Sprint1.Task1.V14.Lib;

namespace Tyuiu.SozonovAD.Sprint1.Task1.V14
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Созонов Александр Дмитриевич | ПКТ6-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* и вычиляет результат по формуле a*b/c+(a/(b+c)) и печатает его          *");
            Console.WriteLine("* на экране.                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a, b, c;
            Console.WriteLine("Введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение c:");
            c = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a,b,c));
            Console.ReadLine();
        }
    }
}
