using System;

namespace Works_____5
{
    class Program
    {

        static int minEl(int[] aray, int minimal, int n)
        {
            int m = 1;

            for (int i = 0; i < n; i++)
            {
                if (aray[i] < minimal)
                {
                    m = i;
                   

                }


            }
            return m;


        }


        static int proizvedenie(int[] aray, int c, int n)
        {
            int c4 = 1;

            for (int i = 0; i < n; i++)
            {
                if (i > c)
                {
                    c4 *= aray[i];


                }
            }
            return c4;

        }
        static void Main(string[] args)
        {
            
           
            int[] aray = { 3, 5, 7, 9, -11, 13, 15 };
            int minimal = 1;
            int n = aray.Length;


            int c = minEl(aray, minimal, n);

            int c2 = proizvedenie(aray, c, n);
            Console.WriteLine(c2);
        }
    }
}
