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
			Solution solution = new Solution();
			string answer = solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight"});
			Console.WriteLine(answer);
		}
	}
}
