using System;

namespace ConsoleApp11
{
    class Program
    {
        /// <summary>
        /// Рекурсивный метод возведения в степень
        /// </summary>
        /// <param name="num">Число</param>
        /// <param name="pow">Степень</param>
        /// <returns>Результат</returns>
        static double Power(double num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            return num * Power(num, pow - 1);
        }

        /// <summary>
        /// Рекурсивный метод вычисления суммы ряда Тейлора
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        private static double Sum(double x, int n = 1, double precision = 1e-10)
        {
            var current = Power(x, n) / n;
            if (current < precision)
            {
                return current;
            }

            return current + Sum(x, n + 1, precision);
        }

        /// <summary>
        /// Метод вычисления ln(1-x)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="precision">Точность</param>
        /// <returns>Результат</returns>
        public static double Ln1MinusX(double x, double precision = 1e-10)
        {
            return -Sum(x, precision: precision);
        }

        public static void Main()
        {
            Console.Write("x = ");
            var x = double.Parse(Console.ReadLine());
            var result = Ln1MinusX(x);
            Console.WriteLine("Ln1MinusX(x)  = {0}", result);
            Console.WriteLine("Math.Log(1-x) = {0}", Math.Log(1 - x));
            Console.ReadKey(true);
        }
    }
}
