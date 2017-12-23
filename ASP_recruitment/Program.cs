using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] cars = { 1, 4, 7, 2, 10, 15, 8 };
			var pumps = 6;
			var task1 = CarRefuelingTimeCalculator.TimeCount(cars, pumps);	
			var task2 = SortingAlgorithm.SortStrByDigits("wyraz124 wyraz335 wy0raz 654wyraz 2wyrazy");
			var task3 = IntToHexConverter.ConvertToHexadecimal(125, 125, 125);
			Console.WriteLine(task1);
			Console.WriteLine(task2);
			Console.WriteLine(task3);
			Console.Read();


		}
	}
}
