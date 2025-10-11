using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeApp
{
	public class Challenge
	{
    public int[] TwoSum(int[] nums, int target) 
    {
      //Input: nums = [3,2,4], target = 6
      //Output: [1,2]
      int outerIndex = 0;
      int lengthOfArray = nums.Count();
      List<int> actualSolution = new List<int>();
      bool isSolved = false;
			foreach (int number in nums) 
      {
        int innerIndex = 0;
        foreach(int value in nums)
        {
          // Can't add the same number in array to itself
          if (innerIndex == outerIndex)
          {
            continue;
          }
          bool solution = number + value == target;
          if (solution) 
          {
            actualSolution = new List<int>()
            {
              innerIndex,
              outerIndex
            };
            isSolved = true;
            break;
          }
          innerIndex++;
        }
        if (isSolved)
        {
          break;
        }
        outerIndex++;
      }

      return new int[] { actualSolution[0], actualSolution[1] };
    }
	}
}
