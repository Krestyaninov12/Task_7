using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение ребра куба");
            int L = Convert.ToInt32(Console.ReadLine());
           
           CalcV_S(L);
                     
            Console.ReadKey();
        }
        static void CalcV_S(int a)
        {
            int S = 6*a*a;
            int V = a * a * a;
            Console.WriteLine("Объем куба равен {0}, площадь равна {1}", V, S);
        }
    }
    }

