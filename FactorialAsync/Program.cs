using System;
using System.Threading.Tasks;

namespace FactorialAsync
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(Factorial(5));     // = 120

			Console.ReadKey();
		}


		public static double Factorial(double x)
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
				return x * Factorial(x - 1);
			}
		}


		public static async Task GetFactorial(int x)
		{
			return await Factorial(x);
		}

	}
}
