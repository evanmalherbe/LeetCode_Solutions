using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution(); // "flower", "flow", "flight"
			string[] input = new string[] {"dog","racecar","car"}; 
			string answer = solution.LongestCommonPrefix(input);
			Console.WriteLine(answer);
		}
	}
}
