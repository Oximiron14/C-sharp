//4ЛБ//
//2 вариант//

using System;

namespace _4Lb_C_charp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = Convert.ToDouble(Console.ReadLine());
            

            double b = Convert.ToDouble(Console.ReadLine());
           

            double c = Convert.ToDouble(Console.ReadLine());
            


         

            double a1 = mediana ( a,b,c);
            Console.WriteLine(a1);

            static double  mediana (double  A, double  B, double  C)
            {
                double  m = 0.5 * Math.Sqrt(2 * Math.Pow(B, 2) + (2 * Math.Pow(C, 2) - (Math.Pow(A, 2))));
                return m;
            }
        }
     
    }
}
