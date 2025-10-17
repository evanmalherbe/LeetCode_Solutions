using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
	public class Solution
	{
		public int RomanToInteger(string s)
		{
			if (s.Length < 1 || s.Length > 15)
			{
				// invalid input
				return -1;
			}
			char[] chars = s.ToCharArray();
			char[] allowedChars = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
			foreach (char letter in chars)
			{
				if (!allowedChars.Contains(letter))
				{
					// invalid input
					return -1;
				}
			}

			//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
			//Symbol       Value
			//I             1
			//V             5
			//X             10
			//L             50
			//C             100
			//D             500
			//M             1000	

			List<Translation> translations = new List<Translation>()
			{
				new Translation()
				{
					Roman = "CM",
					Number = 900,
					Type = "100"
				},
				// 1000s
				new Translation()
				{
					Roman = "M",
					Number = 1000,
					Type = "1000"
				},
				// 100s
				new Translation()
				{
					Roman = "CD",
					Number = 400,
					Type = "100"
				},
				new Translation()
				{
					Roman = "D",
					Number = 500,
					Type = "100"
				},
				// 10s
				new Translation()
				{
					Roman = "XC",
					Number = 90,
					Type = "100"
				},
				new Translation()
				{
					Roman = "C",
					Number = 100,
					Type = "100"
				},
				new Translation()
				{
					Roman = "XL",
					Number = 40,
					Type = "10"
				},
				new Translation()
				{
					Roman = "L",
					Number = 50,
					Type = "10"
				},
				new Translation()
				{
					Roman = "IX",
					Number = 9,
					Type = "1"
				},
				new Translation()
				{
					Roman = "X",
					Number = 10,
					Type = "10"
				},
				// ones 
				new Translation()
				{
					Roman = "IV",
					Number = 4,
					Type = "1"
				},
				new Translation()
				{
					Roman = "V",
					Number = 5,
					Type = "1"
				},
				new Translation()
				{
					Roman = "III",
					Number = 3,
					Type = "1"
				},
				new Translation()
				{
					Roman = "II",
					Number = 2,
					Type = "1"
				},
				new Translation()
				{
					Roman = "I",
					Number = 1,
					Type = "1"
				},
			};

			List<int> numbers = new List<int>();
			List<SkipType> skipTypes = new List<SkipType>()
			{
				new SkipType() {Type = "1000", ToSkip = false},
				new SkipType() {Type = "100", ToSkip = false},
				new SkipType() {Type = "10", ToSkip = false },
				new SkipType() {Type = "1", ToSkip = false}
			};

			foreach (var translation in translations)
			{
				if (s.Contains(translation.Roman))
				{
					// remove matched string from original string
					int lengthOfMatchedString = translation.Roman.Length;
					int indexOfString = s.IndexOf(translation.Roman);
					if (indexOfString != -1) 
					{
						s = s.Remove(indexOfString, lengthOfMatchedString);
					}
					// add number to total
					numbers.Add(translation.Number);
				}
			}

			int total = 0;
			foreach (int num in numbers)
			{
				total += num;
			}

			return total;
		}

	}
}
