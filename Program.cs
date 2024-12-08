//3ЛБ//
//ВАРИАНТ 3//

namespace _3LB_Ccharp
{
    class Program
    {
        static void Main(string[] args)
        {
			double y;
			double x;
			double c = 7;

			
			for (x = 0; x <= 1; x += 0.1)
			{
				y = Math.Pow(2, -x) * Math.Pow(c, x);
				Console.WriteLine(y);
			}
			Console.WriteLine(".......");

			x = -1;



			while (x <= 1)
			{
				y = Math.Pow(2, -x) * Math.Pow(c, x);
				x += 0.1;
				Console.WriteLine(y);
			}
			

			x = 0.1;

			do
			{
				y = Math.Pow(2, -x) * Math.Pow(c, x);
				x += 0.1;
				Console.WriteLine(y);
			} while (x <= 1);


		}
	}
    
}
