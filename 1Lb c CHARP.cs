using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
       
            double y = Convert.ToDouble(Console.ReadLine());
          
            double c = Math.Pow((y * Math.Pow(x, 2) - 1), 2) / 2 * (Math.Pow(Math.Cos(y), 2) - Math.Sin(Math.Pow(x, 2)));
            Console.WriteLine(c);



        }
    }
}
