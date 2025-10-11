using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			bool answer = solution.IsPalindrome(121);
			Console.WriteLine(answer);
		}
	}
}
