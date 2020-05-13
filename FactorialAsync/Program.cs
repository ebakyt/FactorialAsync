using System;

namespace FactorialAsync
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(Factorial(5));     // = 120

			Console.ReadKey();
		}


		public static async Task<double> Factorial(double x)
		{
			if (x < 1)
			{
				return 1;
			}

			if (x == 1)
			{
				return 1;
			}
			else
			{
				return x * await Factorial(x - 1);
			}
		}

	}
}
