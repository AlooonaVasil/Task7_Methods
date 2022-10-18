using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа сравнивает площиди двух треугольников");
            int a1 = GetSide(1, 1);
            int b1 = GetSide(2, 1);
            int c1 = GetSide(3, 1);
            int a2 = GetSide(1, 2);
            int b2 = GetSide(2, 2);
            int c2 = GetSide(3, 2);

            GetSquare(a1, b1, c1, out double s1);
            GetSquare(a2, b2, c2, out double s2);
            
            if (s1 == 0 || s1 is double.NaN) Console.WriteLine("Треугольника 1 не существует");
            else if (s2 == 0 || s2 is double.NaN) Console.WriteLine("Треугольника 2 не существует");
            else if (s1 > s2)
                Console.WriteLine("Площадь треугольника 1 ({0:F2}) больше площади треугольника 2 ({1:F2})", s1, s2);
            else if (s1 < s2)
                Console.WriteLine("Площадь треугольника 2 ({0:F2}) больше площади треугольника 1 ({1:F2})", s2, s1);
            else
                Console.WriteLine("Площадь треугольника 1 ({0:F2}) равна площади треугольника 2 ({1:F2})", s1, s2);
            Console.ReadKey();
        }
        static int GetSide(int side, int trian)
        {
            Console.WriteLine("Введите {0} сторону треугольника {1}", side, trian);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        static double GetSquare(int a, int b, int c, out double s)
        {
            double p = (a + b + c) / 2.0;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
