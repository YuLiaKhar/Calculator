using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число. Х = ");
            double x, y;
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
            Console.Write("Введите целое число. Y = ");
            try
            {
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите код операции: \n 1 - сложение \n 2 - вычитание \n 3 - умножение \n 4 - деление");
            int[] a = new int[4] { 1, 2, 3, 4 };
            int i;
            int k = 0;
            Console.Write("Ваш выбор: ");
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                k = a[i - 1];
            }
            catch (Exception)
            {
                Console.WriteLine("Нет операции с указанным номером.");
            }
            if (k == 1)
            {
                double s = x + y;
                Console.WriteLine("{0} + {1} = {2}", x, y, Math.Round (s, 2));
            }
            else if (k == 2)
            {
                double s = x - y;
                Console.WriteLine("{0} - {1} = {2}", x, y, Math.Round(s, 2));
            }
            else if (k == 3)
            {
                double s = x * y;
                Console.WriteLine("{0} * {1} = {2}", x, y, Math.Round(s, 2));
            }
            else if (k == 4)
            {
                if (y==0)
                {
                    Console.WriteLine("Ошибка! Нельзя разделить на 0.");
                }
                else
                {
                    double s = x / y;
                    Console.WriteLine("{0} / {1} = {2}", x, y, Math.Round(s, 2));
                }
                //try
                //{
                //    double s = x / y;
                //}
                //catch (DivideByZeroException) when (y == 0)
                //{
                //    Console.WriteLine("Ошибка! Нельзя разделить на 0.");
                //}
                // почему-то программа игнорирует исключение. вместо сообщения об ошибке выдает ответ "4/0=?"
            }
            Console.ReadKey();
        }
    }
}
