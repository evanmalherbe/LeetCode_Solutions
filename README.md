# My LeetCode Solutions 2025
This repository is for all the leetcode coding challenges I've done - [LeetCode Website](https://leetcode.com/). I've put each challenge's code solution into it's own folder with the challenge name and it's difficulty level (according to the LeetCode website).

## Languages
I mainly focus on coding challenges using C# (.NET Core and Framework), Javascript and SQL.

## Solutions (Easy)
1. [1. Two Sum](#1-two-sum)
2. [9. Palindrome Number](#9-palindrome-number)
3. [13. Roman To Integer](#13-roman-to-integer)

## 1. Two Sum
**Difficulty - Easy**<br>
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. You may assume that each input would have exactly one solution, and you may not use the same element twice. You can return the answer in any order.

**Example 1:**<br>
Input: nums = [2,7,11,15], target = 9<br>
Output: [0,1]<br>
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].<br>

**Example 2:**<br>
Input: nums = [3,2,4], target = 6<br>
Output: [1,2]<br>

**Example 3:**<br>
Input: nums = [3,3], target = 6<br>
Output: [0,1]<br>

**Constraints:**<br>
2 <= nums.length <= 104<br>
-109 <= nums[i] <= 109<br>
-109 <= target <= 109<br>

Only one valid answer exists.

## 9. Palindrome Number
**Difficulty - Easy**<br>
Given an integer x, return true if x is a palindrome, and false otherwise.

**Example 1:**<br>
Input: x = 121<br>
Output: true<br>
Explanation: 121 reads as 121 from left to right and from right to left.<br>

**Example 2:**<br>
Input: x = -121<br>
Output: false<br>
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.<br>

**Example 3:**<br>
Input: x = 10<br>
Output: false<br>
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.<br>

**Constraints:**<br>
-231 <= x <= 231 - 1

## 13. Roman To Integer
**Difficulty - Easy**<br>
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

** Example 1:**<br>
Input: s = "III"<br>
Output: 3<br>
Explanation: III = 3.<br>

** Example 2:**<br>
Input: s = "LVIII"<br>
Output: 58<br>
Explanation: L = 50, V= 5, III = 3.<br>

** Example 3:**<br>
Input: s = "MCMXCIV"<br>
Output: 1994<br>
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.<br>
 
** Constraints:**<br>
- 1 <= s.length <= 15<br>
- s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').<br>
- It is guaranteed that s is a valid roman numeral in the range [1, 3999].<br>