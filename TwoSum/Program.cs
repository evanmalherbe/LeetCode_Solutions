using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			Challenge challenge = new Challenge();
    
			int[] output = challenge.TwoSum(new int[] {3,3}, 6);
			Console.WriteLine($"The solution is: [{output[0]},{output[1]}]." );
		}
	}
}
