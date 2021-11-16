using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длины стороны а первого треугольника");
          int tr1_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение длины стороны b первого треугольника");
            int tr1_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение длины стороны с первого треугольника");
            int tr1_z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение длины стороны а второго треугольника");
            int tr2_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение длины стороны b второго треугольника");
            int tr2_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение длины стороны с второго треугольника");
            int tr2_z = Convert.ToInt32(Console.ReadLine());
            int S1 = CalcS(tr1_x, tr1_y, tr1_z);
            int S2 = CalcS(tr2_x, tr2_y, tr2_z);

            if (S1 == S2)
            {
                Console.WriteLine("Площади одинаковые");
            }
            else
            {
                if (S1 > S2)
                {
                    Console.WriteLine("Площадь первого треугольника больше");
                }

                else
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
            }
                Console.ReadKey();             
        }            
       static int CalcS(int side1, int side2, int side3)
        { int P = (side1 + side2 + side3) / 2;
            int S = (int)Math.Sqrt((P*(P-side1)*(P-side2)*(P-side3)));
            return S; }
        
    }
}
