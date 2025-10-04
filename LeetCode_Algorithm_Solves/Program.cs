using System;
using System.Collections.Generic;

namespace LeetCode_Algorithm_Solves
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 1. Two Sum

            // int[] nums1 = { 2, 7, 11, 15 };
            // int target1 = 9;
            //
            // int[] result1 = TwoSum(nums1, target1);
            // Console.WriteLine($"Result 1: [{result1[0]},  {result1[1]}]");
            //
            #endregion
            #region 2. Add Two Numbers
            // int[] nums1 = { 2, 4, 3 }; // Represents 342
            // int[] nums2 = { 5, 6, 4 }; // Represents 465
            //
            // ListNode l1 = CreateLinkedList(nums1);
            // ListNode l2 = CreateLinkedList(nums2);
            //
            // ListNode result = AddTwoNumbers(l1, l2);
            // Console.WriteLine("Result for Test Case 1: ");
            // PrintLinkedList(result); // Expected Output: 7 0 8 (807)

            #endregion
            #region 3. Longest Substring Without Repeating Characters

            // string[] testStrings = { "abcabcbb", "bbbbb", "pwwkew", "au" };
            //
            // foreach (var test in testStrings)
            // {
            //     int result = LengthOfLongestSubstring(test);
            //     Console.WriteLine($"Input: {test} -> Length of the Longest Substing with Repeating Characters: {result}");
            //
            // }

            #endregion
            #region 9. Palindrome Number

            // Console.WriteLine(IsPalindrome(121));

            #endregion
            #region    4. Median of Two Sorted Arrays
            double median = FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
            Console.WriteLine($"Median is: {median}");
            #endregion
            
        }

        #region    4. Median of Two Sorted Arrays
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            // Ensure nums1 is the smaller array
            if (nums1.Length > nums2.Length) {
                return FindMedianSortedArrays(nums2, nums1);
            }

            int x = nums1.Length;
            int y = nums2.Length;
            int low = 0, high = x;

            while (low <= high) {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

                int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

                if (maxLeftX <= minRightY && maxLeftY <= minRightX) {
                    if ((x + y) % 2 == 0) {
                        return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                    } else {
                        return Math.Max(maxLeftX, maxLeftY);
                    }
                } else if (maxLeftX > minRightY) {
                    high = partitionX - 1;
                } else {
                    low = partitionX + 1;
                }
            }

            throw new ArgumentException("Input arrays are not sorted properly.");
        }

        #endregion
        #region 13. Roman to Integer

        // public int RomanToInt(string s) {
        //     Dictionary<char, int> romanValues = new Dictionary<char, int> 
        //     {
        //         {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
        //         {'C', 100}, {'D', 500}, {'M', 1000}
        //     };
        //
        //     int result = 0;
        //
        //     for (int i = 0; i < s.Length; i++) 
        //     {
        //         if (i + 1 < s.Length && romanValues[s[i]] < romanValues[s[i + 1]]) 
        //         {
        //             result -= romanValues[s[i]];
        //         } 
        //         else 
        //         {
        //             result += romanValues[s[i]];
        //         }
        //     }
        //
        //     return result;
        // }

        #endregion
        #region 9. Palindrome Number

        // public static bool IsPalindrome(int x) 
        // {
        //     if (x < 0 || (x % 10 == 0 && x != 0)) {
        //         return false;
        //     }
        //
        //     int reversedHalf = 0;
        //
        //     while (x > reversedHalf) {
        //         reversedHalf = reversedHalf * 10 + x % 10;
        //         x /= 10;
        //     }
        //
        //     return x == reversedHalf || x == reversedHalf / 10;
        // }
    

        #endregion
        #region 3. Longest Substring Without Repeating Characters

        // public static int LengthOfLongestSubstring(string s)
        // {
        //     Dictionary<char, int> charIndexMap = new Dictionary<char, int>();  
        //
        //     int left = 0; 
        //     int maxLen = 0;  
        //
        //     for (int right = 0; right < s.Length; right++) {
        //    
        //         if (charIndexMap.ContainsKey(s[right]) && charIndexMap[s[right]] >= left) {
        //        
        //             left = charIndexMap[s[right]] + 1;
        //         }
        //  
        //         charIndexMap[s[right]] = right;
        //
        //         maxLen = Math.Max(maxLen, right - left + 1);
        //     }
        //
        //     return maxLen;
        // }
        #endregion
        #region 2. Add Two Numbers

        // public  class ListNode
        // {
        //     public int val;
        //     public ListNode next;
        //
        //     public ListNode(int val = 0, ListNode next = null)
        //     {
        //         this.val = val;
        //         this.next = next; 
        //     }
        // }
        // public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        // {
        //     ListNode dummyHead = new ListNode();
        //     ListNode current = dummyHead;
        //     int carry = 0;
        //
        //     while (l1 !=null || l2 != null || carry!= 0)
        //     {
        //         int sum = carry;
        //
        //         if (l1 != null)
        //         {
        //             sum += l1.val;
        //             l1 = l1.next;
        //         }
        //
        //         if (l2 != null)
        //         {
        //             sum += l2.val;
        //             l2 = l2.next;
        //         }
        //
        //         carry = sum / 10;
        //         current.next = new ListNode(sum % 10);
        //         current = current.next;
        //     }
        //
        //     return dummyHead.next;
        //
        // }   
        // public static ListNode CreateLinkedList(int[] values) {
        //     ListNode dummyHead = new ListNode();
        //     ListNode current = dummyHead;
        //     foreach (int value in values) {
        //         current.next = new ListNode(value);
        //         current = current.next;
        //     }
        //     return dummyHead.next;
        // }
        // public static void PrintLinkedList(ListNode head) {
        //     ListNode current = head;
        //     while (current != null) {
        //         Console.Write(current.val + " ");
        //         current = current.next;
        //     }
        //     Console.WriteLine();
        // }
        
        #endregion
        #region 1. Two Sum
        // static int[] TwoSum(int[] nums, int target)
        // {
        //     Dictionary<int, int> map = new Dictionary<int, int>();
        //
        //     for (int i = 0; i < nums.Length; i++)
        //     {
        //         int complement = target - nums[i];
        //
        //         if (map.ContainsKey(complement))
        //         {
        //             return new int[] { map[complement], i };
        //         }
        //
        //         if (!map.ContainsKey((nums[i])))
        //         {
        //             map[nums[i]] = i;
        //         }
        //     }
        //     
        //     return new int[] { };
        // }
        
        #endregion
    }
}