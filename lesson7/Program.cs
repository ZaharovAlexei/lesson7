using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Два треугольника заданы длинами своих сторон.
            //Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
            //Для решения задачи можно использовать формулу Герона , где x, y, z – стороны треугольника, p – полупериметр.
            
            Console.WriteLine("Введите длины 3-х сторон 1-го треугольника");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double s = CalcTri(a, b, c);
            Console.WriteLine("Площадь треугольника равна = {0}", s);
            double s1 = s;
            Console.WriteLine("Введите длины 3-х сторон 2-го треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            s = CalcTri(a, b, c);
            Console.WriteLine("Площадь треугольника равна = {0}", s);
            double s2 = s;
            if (s1 > s2)
            {
                Console.WriteLine("Площадь 1-го треугольника больше");
            }
            else
            {
                if (s1 < s2)
                {
                    Console.WriteLine("Площадь 2-го треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площади 1-го и 2-го треугольников равны");
                }
            }
            Console.ReadKey();
        }        
        static double CalcTri(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

    }
}
