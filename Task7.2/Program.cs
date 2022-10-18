using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа считает объем и площадь поверхности куба");
            Console.WriteLine("Введите ребро куба");
            double rebro = Convert.ToDouble(Console.ReadLine());
            GetVolumeAndSquare(rebro, out double volume, out double square);
            Console.WriteLine("Объем куба = {0:f2}", volume);
            Console.WriteLine("Площадь поверхности куба = {0:f3}", square);
            Console.ReadKey();
        }
        static void GetVolumeAndSquare(double rebro, out double volume, out double square)
        {
            volume = Math.Pow(rebro, 3);
            square = 6 * Math.Pow(rebro, 2);            
        }
    }
}
