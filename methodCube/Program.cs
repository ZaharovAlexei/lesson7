using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodCube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать метод для вычисления объема и площади поверхности куба по длине его ребра
            double a = Convert.ToDouble(Console.ReadLine());
            CalcCube(a);
            Console.ReadKey();
        }
        static void CalcCube(double a)
        {
            double v = Math.Pow(a,3);
            double s=6*Math.Pow(a,2);
            Console.WriteLine("Объем куба равен {0}",v);
            Console.WriteLine("Площадь поверхности куба равна {0}", s);
        }
    }
}
