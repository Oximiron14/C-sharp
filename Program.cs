using System;

namespace C_charp_LB2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = Convert.ToDouble(Console.ReadLine());

            double y = Convert.ToDouble(Console.ReadLine());

            double e = Convert.ToDouble(Console.ReadLine());

            double a = Convert.ToDouble(Console.ReadLine());

            double b = Convert.ToDouble(Console.ReadLine());

            double n = (0);

            double g = Convert.ToDouble(Console.ReadLine());

            double l = Convert.ToDouble(Console.ReadLine());

            double minEl = y;
            if (minEl > a * x)
            {
                minEl = a * x;
            }

            double maxEl = Math.Pow(x, 3) * Math.Pow(e, y);
            if (maxEl > Math.Sqrt(Math.Log(Math.Pow(y, 2))))
            {
                maxEl = Math.Sqrt(Math.Log(Math.Pow(y, 2)));
            }

            double k;

            if (x * y > 0)
            {

                double z = Math.Pow(1 - e, x * y + a * b);
                Console.WriteLine(z);

                if (minEl > a * x) ;
                {
                    minEl = a * x;

                }
                double p = maxEl;
                p = Math.Pow(x, 3) * Math.Pow(e, y);

                if (p > Math.Sqrt(Math.Log(y, 2))) ;

                maxEl = Math.Sqrt(Math.Log(Math.Pow(y, 2)));

                double q;




            }
            else if  (x * y == n)
            {
                double c = (b - (minEl));

                Console.WriteLine(c);
            }
            else if (x * y < 0)
            {
                double j;
                j = maxEl;
                Console.WriteLine(j);
            }

        }
    }
}

            