using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise2_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();

			int sizeA = r.Next(5, 10);
			int sizeB = r.Next(5, 10);
			int[] a = new int [sizeA];
			int[] b = new int [sizeB];
			buildarr(a,b);			
			int result = 0;
			Measure(a, b, ref result);
			Console.WriteLine(result);

		}

		private static void buildarr(int[] a, int [] b)
		{
			Random n = new Random();
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = n.Next(100);
				Console.Write($"{a[i]}  ");
			}
			Console.WriteLine();
			
			for (int i = 0; i < b.Length; i++)
			{
				b[i] = n.Next(100);
				Console.Write($"{b[i]}  ");
			}
			Console.WriteLine();
		}


		private static int Measure(int[] a, int[] b, ref int result)
		{
			int l;
			int sumA = 0;
			int sumB = 0;
			result = 0;
			
			if (a.Length > b.Length)
			{
				l = b.Length;
			}
			else
			{
				l = a.Length;
			}
			for (int i = 0; i < l; i++)
			{
				if (a[i] > b [i])
				{
					sumA++;
				}
				if (b[i] > a[i])
				{
					sumB++;
				}

			}
			if (sumA > sumB)
			{
				result = 1;
			}
			if (sumB > sumA)
			{
				result = -1;
			}
			return result;
		}
	}
}
