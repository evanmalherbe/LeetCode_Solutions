using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
	public class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int answer = solution.RomanToInteger("LVIII");
			if (answer == -1) 
			{
				Console.WriteLine("Too many or too few characters");
			}
			Console.WriteLine("Answer: " + answer);
		}
	}
}
