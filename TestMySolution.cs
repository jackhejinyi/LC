using System.Numerics;

namespace MyTry
{
    public class TestClass
    {
        public static void Main(string[] args)
        {
            #region "Practice secction"
            //// 344. Reverse String - easy
            //char[] s = ['H', 'e', 'l', 'l', 'o'];
            //char[] s2 = ['J', 'a', 'c', 'k'];
            //char[] s3 = ['M'];

            //MySolution.ReverseStringRef(s);
            //Printer(s);

            //MySolution.ReverseStringRef(s2);
            //Printer(s2);

            //MySolution.ReverseStringRef(s3);
            //Printer(s3);

            // 7. Reverse Integer - Medium
            //Console.WriteLine(MySolution.Reverse(123));
            //Console.WriteLine(MySolution.Reverse(120));
            //Console.WriteLine(MySolution.Reverse(-123));
            //Console.WriteLine(MySolution.Reverse(1534236469));
            //Console.WriteLine(MySolution.Reverse(-1000000003));
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            // 1. Two Sum - Easy
            //int[] arr1 = { 1, 2 };
            //int[] arr2 = { 3, 3 };
            //int target = 6;

            //int[] result1 = MySolution.TwoSumTimeOpt(arr1, target);
            //int[] result2 = MySolution.TwoSumTimeOpt(arr2, target);
            //PrinterIntArr(result1);
            //PrinterIntArr(result2);

            //int[] arr3 = [2, 15, 11, 7];
            //int[] arr4 = [2, 6, 11, 15];
            //target = 9;
            //int[] result3 = MySolution.TwoSumTimeOpt(arr3, target);
            //PrinterIntArr(result3);
            //int[] result4 = MySolution.TwoSumTimeOpt(arr4, target);
            //PrinterIntArr(result4);

            //int[] arr5 = [1, 1, 2, 1, 1, 7, 13, 1, 8];
            //int target = 9;
            //var  result5 = MySolution.TwoSumTimeOpt(arr5, target);
            //MyUtils.PrinterIntArr(result5);

            //string s1 = "()";
            //string s2 = "()[]{}";
            //string s3 = "(]";
            //string s4 = "([])";
            //string s5 = ")(";

            //string[] strings = { s1, s2, s3, s4, s5 };
            //foreach (string s in strings)
            //{
            //    Console.WriteLine(MySolution.IsValid(s));
            //}
            //Console.WriteLine(MySolution.IsValid(s3));

            //string[] menu1 = ["toast", "bread", "breada", "cheese"];
            //string[] menu2 = null;
            //string s1 = "abcdeehrs";
            //string s2 = "aabcdeehrs";
            //string s3 = null;
            //Console.WriteLine(MySolution.DishNums(menu1, s1));
            //Console.WriteLine(MySolution.DishNums(menu1, s2));
            //Console.WriteLine(MySolution.DishNums(menu2, s3));

            // 26. Remove Duplicates from Sorted Array
            //int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

            //Console.WriteLine(MySolution.RemoveDuplicates(nums));

            // 189. Rotate Array
            //int[] arr1 = [1, 2, 3, 4, 5, 6, 7];
            //int k1 = 3;

            //MySolution.RotateS3(arr1, k1);
            //PrinterIntArr(arr1);

            //int[] arr2 = [-1, -100, 3, 99];
            //int k2 = 2;

            //MySolution.RotateS3(arr2, k2);
            //PrinterIntArr(arr2);

            //int[] arr3 = [1, 3];
            //int k3 = 3;

            //MySolution.RotateS3(arr3, k3);
            //PrinterIntArr(arr3);

            //// 217. Contains Duplicate
            //int[] arr1 = [1, 2, 3, 1];
            //Console.WriteLine(MySolution.ContainsDuplicateS3(arr1));

            //int[] arr2 = [1, 2, 3, 4];
            //Console.WriteLine(MySolution.ContainsDuplicateS3(arr2));

            //int[] arr3 = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
            //Console.WriteLine(MySolution.ContainsDuplicateS3(arr3));

            //int[] arr1 = [2, 2, 5];
            //int[] arr2 = [4, 1, 2, 1, 2];
            //int[] arr3 = [5];

            //Console.WriteLine(MySolution.SingleNumberS2(arr1));
            //Console.WriteLine(MySolution.SingleNumberS2(arr2));
            //Console.WriteLine(MySolution.SingleNumberS2(arr3));

            // 66. Plus One
            //int[] arr1 = [9];
            //int[] arr2 = [1, 2, 3];
            //int[] arr3 = [9, 9];

            //MyUtils.PrinterIntArr(MySolution.PlusOneS2(arr1));
            //MyUtils.PrinterIntArr(MySolution.PlusOneS2(arr2));
            //MyUtils.PrinterIntArr(MySolution.PlusOneS2(arr3));

            // 283. Move Zeroes
            //int[] arr1 = [0, 0, 1, 0, 3, 12];
            //int[] arr2 = [0];
            //int[] arr3 = [1, 0];
            //int[] arr4 = [1, 0, 2, 0, 0, 12];
            //int[] arr5 = [1, 12];

            //int[][] arrs = new int[][] {
            //arr1, 
            //arr2,
            //arr3,
            //arr4,
            //arr5
            //};

            //MySolution.MoveZeroesS2(arr1);
            //MyUtils.PrinterIntArr(arr1);

            //MySolution.MoveZeroesS2(arr2);
            //MyUtils.PrinterIntArr(arr2);

            //MySolution.MoveZeroesS2(arr3);
            //MyUtils.PrinterIntArr(arr3);

            //MySolution.MoveZeroesS2(arr4);
            //MyUtils.PrinterIntArr(arr4);

            //MySolution.MoveZeroesS2(arr5);
            //MyUtils.PrinterIntArr(arr5);

            // 349. Intersection of Two Arrays
            //int[] arr1 = [1, 2, 2, 1];
            //int[] arr2 = [2, 2];

            //int[] arr3 = {3};
            //int[] arr4 = {2};

            //int[] arr5 = {3, 2, 2, 3, 4, 1};
            //int[] arr6 = { 3, 5, 5, 4, 9 };

            //MyUtils.PrinterIntArr(MySolution.Intersect2S1(arr1, arr2));
            //MyUtils.PrinterIntArr(MySolution.Intersect2S1(arr3, arr4));
            //MyUtils.PrinterIntArr(MySolution.Intersect2S1(arr1, arr3));
            //MyUtils.PrinterIntArr(MySolution.Intersect2S1(arr5, arr6));

            // 121.Best Time to Buy and Sell Stock
            //int[] prices1 = [7, 1, 5, 3, 6, 4];
            //int[] prices2 = [7, 6, 5, 4, 3, 2, 1];
            //int[] prices3 = [7];
            //int[] prices4 = [1, 2, 3, 4, 5];

            //Console.WriteLine(MySolution.MaxProfitII(prices1));
            //Console.WriteLine(MySolution.MaxProfitII(prices2));
            //Console.WriteLine(MySolution.MaxProfitII(prices3));
            //Console.WriteLine(MySolution.MaxProfitII(prices4));

            //string s = "abcdefgh";
            //int k = 3;
            //string s1 = "abcdefghi";

            //Console.WriteLine(MySolution.ReverseStrOpt(s, k));
            //Console.WriteLine(MySolution.ReverseStrOpt(s, k - 1));
            //Console.WriteLine(MySolution.ReverseStrOpt(s1, k));

            // 242. Valid Anagram - Easy
            //string s1 = "anagram";
            //string t1= "nagaram";

            //Console.WriteLine(MySolution.IsAnagram(s1, t1));

            //string s2 = "rat";
            //string t2 = "car";

            //Console.WriteLine(MySolution.IsAnagram(s2, t2));

            // 387. First Unique Character in a String
            //string s1 = "loveleetcode";
            //string s2 = "aabb";
            //string s3 = "leetcode";

            //Console.WriteLine(MySolution.FirstUniqChar(s1));
            //Console.WriteLine(MySolution.FirstUniqChar(s2));
            //Console.WriteLine(MySolution.FirstUniqChar(s3));


            // 125. Valid Palindrome
            //string s1 = "A man, a plan, a canal: Panama";
            //string s2 = "race a car";
            //string s3 = "";

            //Console.WriteLine(MySolution.IsPalindrome(s1));
            //Console.WriteLine(MySolution.IsPalindrome(s2));
            //Console.WriteLine(MySolution.IsPalindrome(s3));

            // No # Implement strStr()
            //string whole = "sadbutsad";
            //string part = "sad";

            //string whole2 = "leetcode";
            //string part2 = "leeto";

            //string whole3 = "leet";
            //string part3 = "leet";

            //Console.WriteLine(MySolution.StrStr(whole, part));
            //Console.WriteLine(MySolution.StrStrS2(whole2, part2));
            //Console.WriteLine(MySolution.StrStr(whole3, part3));

            // 14. Longest Common Prefix
            //string[] strs = ["flower", "flow", "flight"];
            //string[] strs2 = ["dog", "racecar", "car"];
            //string[] strs3 = ["", "racecar", "car"];


            //Console.WriteLine(MySolution.LongestCommonPrefixRef(strs2));
            //Console.WriteLine(MySolution.LongestCommonPrefixRef(strs3));
            //Console.WriteLine(MySolution.LongestCommonPrefixRef(strs));

            // 8. String to Integer (atoi)
            //string s1 = "   1337c0d3"; // Passed
            //string s2 = " -042"; // Passed
            //string s3 = "0-1"; // Failed
            //string s4 = "words and 987";
            //string s5 = "2147483649";
            //string s6 = "-2147483649";

            //Console.WriteLine(MySolution.MyAtoiRef(s1));
            //Console.WriteLine(MySolution.MyAtoiRef(s2));
            //Console.WriteLine(MySolution.MyAtoiRef(s3));
            //Console.WriteLine(MySolution.MyAtoiRef(s4));
            //Console.WriteLine(MySolution.MyAtoiRef(s5));
            //Console.WriteLine(MySolution.MyAtoiRef(s6));

            // List section
            // Validate AddNodeTrail functionality 
            ListNode node = new ListNode(1);
            node.AddNodeTrail(2);
            node.AddNodeTrail(3);
            node.AddNodeTrail(4);
            node.AddNodeTrail(5);

            Console.Write("Origin List: ");
            MyUtils.PrintListNode(node);
            MyUtils.PrintListNode(MySolution.RemoveNthFromEndRef(node, 2));
            
            ListNode node2  = new ListNode(1);
            node2.AddNodeTrail(2);
            Console.Write("Origin List: ");
            MyUtils.PrintListNode(node2);
            MyUtils.PrintListNode(MySolution.RemoveNthFromEndRef(node2, 2));

            ListNode node3 = new ListNode(1);
            Console.Write("Origin List: ");
            MyUtils.PrintListNode(node3);
            MyUtils.PrintListNode(MySolution.RemoveNthFromEndRef(node3, 1));

            #endregion

            #region "Career Cup - Top 150 Questions"
            // List section

            #endregion
            #region "Review section"
            // Review : #7 Reverse Integer
            //Console.WriteLine(SolutionReview.Reverse(321));
            //Console.WriteLine(SolutionReview.Reverse(-321));
            //Console.WriteLine(SolutionReview.Reverse(1534236469));
            //Console.WriteLine(MySolution.Reverse(-1000000003));
            #endregion

        }

    }
}
