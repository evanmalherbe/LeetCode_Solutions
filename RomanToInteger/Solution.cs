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

			int index = 0;
			foreach (var translation in translations)
			{
				if (index != 0 && skipTypes.FirstOrDefault(i => i.Type == translation.Type).ToSkip == true)
				{
					continue;
				}
				if (s.Contains(translation.Roman))
				{
					numbers.Add(translation.Number);
					SkipType skipValue = skipTypes.FirstOrDefault(i => i.Type == translation.Type && i.ToSkip == false);
					skipValue.ToSkip = true;
				}
				index++;
			}

			//char[] chars2 = s.ToCharArray();
			//List<int> subTotalArray = new List<int>();
			//foreach (char c in chars)
			//{
			//	int number = 0;
			//	switch (c)
			//	{
			//		case 'I':
			//			number = 1;
			//			break;
			//		case 'V':
			//			number = 5;
			//			break;
			//		case 'X':
			//			number = 10;
			//			break;
			//		case 'L':
			//			number = 50;
			//			break;
			//		case 'C':
			//			number = 100;
			//			break;
			//		case 'D':
			//			number = 500;
			//			break;
			//		case 'M':
			//			number = 1000;
			//			break;
			//		default:
			//			number = 0;
			//			break;
			//	}
			//	subTotalArray.Add(number);
			//}
			int total = 0;
			foreach (int num in numbers)
			{
				total += num;
			}

			return total;
		}
	}
}
