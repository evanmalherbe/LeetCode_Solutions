using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
	public class Solution
	{
		public int RomanToInteger(string input)
		{
			//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
			//Symbol       Value
			//I             1
			//V             5
			//X             10
			//L             50
			//C             100
			//D             500
			//M             1000	

			char[] chars = input.ToCharArray();
			List<int> subTotalArray = new List<int>();
			foreach (char c in chars)
			{
				int number = 0;
				switch (c)
				{
					case 'I':
						number = 1;
						break;
					case 'V':
						number = 5;
						break;
					case 'X':
						number = 10;
						break;
					case 'L':
						number = 50;
						break;
					case 'C':
						number = 100;
						break;
					case 'D':
						number = 500; 
						break;
					case 'M':
						number = 1000;
						break;
					default:
						number = 0;
						break;
				}
				subTotalArray.Add(number);
			}
			string subTotalString = "";
			foreach (var num in subTotalArray)
			{
				subTotalString += num.ToString();
			}

			return 0;
		}
	}
}
