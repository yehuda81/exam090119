using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number:");
			int x = Convert.ToInt32(Console.ReadLine());
			Power2(ref x);
			Console.WriteLine($"power 2 of your number is {x}");
		}
		private static int Power2(ref int i)
		{
			i = i * 2;
			return i;
		}	
	}
}
