using System.Text;

namespace MyTry
{
    public static class MySolution
    {
        // 344. Reverse String - easy
        public static void ReverseString(char[] s)
        {
            if (s.Length == 1) return;

            for (int i = 0; i <= s.Length / 2 - 1; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }

        public static void ReverseStringRef(char[] s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
        }

        // 7. Reverse Integer - Medium, solution is provided by CGPT
        // Tips:
        // 1. overflow when reversing
        // 2. positive or negative number
        // 3. e.g. 123 => 3 * 10 + 12, repeat this step until the quotiant == 0;
        public static int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                // Check for overflow before multiplying
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                    return 0;
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                    return 0;

                result = result * 10 + digit;
            }

            return result;
        }

        // 1. Two Sum - Easy
        // Assume that each input would have exactly one solution,
        // and you may not use the same element twice.
        // Tips
        // 1. Consider if edge node is included or excluded
        // 2. Need to consider array's length is 2 separately
        // 3. Consider time complexity o(n) rather than O(n^2)
        public static int[] TwoSum(int[] nums, int target)
        {
            int first = -1, complement = -1;
            int left = 0;

            while (left < nums.Length)
            {
                int temp = left + 1;
                while (temp < nums.Length)
                {
                    if (nums[left] + nums[temp] == target)
                    {
                        first = left; complement = temp;
                        return [first, complement];
                    }
                    temp++;
                }
                left++;
            }

            return [first, complement];
        }

        public static int[] TwoSumTimeOpt(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i }; // Way to define anonymous array
                }
                if (!map.ContainsKey(complement))
                {
                    if (map.ContainsKey(nums[i]))
                    {
                        map[nums[i]]++;
                    }
                    else
                    {
                        map.Add(nums[i], i);
                    }
                }
            }

            //throw new Exception("No two sum solution");
            return new int[] { -1, -1 };
        }

        // 20. Valid Parentheses
        // Tips
        // 1. props and methods for class string
        // 2. Consider: bracket type, bracket order
        // 3. Data structure: stack-LIFO
        // 4. My algorithm: do the following operators
        // when traversing each positon for a string:
        // . if the char is opening bracket, add it to the stack
        // . if the char is closing bracket, remove its opening bracket from the stack
        public static bool IsValid(string s)
        {
            Stack<char> brackets = new Stack<char>();

            foreach (char c in s)
            {
                // Add an elment
                if (c == '(' || c == '[' || c == '{')
                {
                    brackets.Push(c);
                }
                else // Compare and remove an element
                {
                    if (brackets.Count == 0) return false;
                    char r = brackets.Pop();
                    if (r == '(' && c == ')') continue;
                    if (r == '[' && c == ']') continue;
                    if (r == '{' && c == '}') continue;
                    return false;
                }
            }
            return brackets.Count == 0;
        }

        // MS interview question: 给定菜单，根据现有的原料可以做出几道菜
        // Tips
        // 1. Store available using Dictionary<char, int>
        // 2. Traverse array menu and create a dict per dish
        // 3. Traverse each dish dict compared to available, then count 

        public static int DishNums(string[] menu, string m)
        {
            if (menu == null || m == null) return 0;

            Dictionary<char, int> available = MyUtils.CreateMaterialDictionary(m);
            int availDishCount = 0;

            foreach (string dish in menu)
            {
                // Traverse available per dish
                Dictionary<char, int> required = MyUtils.CreateMaterialDictionary(dish);
                bool canCook = true;

                // Compare two dicts: required and available
                foreach (var ingredient in required)
                {
                    if (!available.ContainsKey(ingredient.Key) || available[ingredient.Key] < ingredient.Value)
                    {
                        canCook = false;
                        break;
                    }
                }

                if (canCook == true)
                {
                    availDishCount++;
                }
            }
            return availDishCount;
        }

        // 21. Merge Two Sorted Lists
        // Tips:
        // 1. Consider data structures: define ListNode shown below in class ListNode

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            return new ListNode();
        }

        // 26. Remove Duplicates from Sorted Array
        // Tips:
        // 1. Move element in place

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 1) return 1;

            int index = 0; // Pointer to store indexes of correct number

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[index])
                {
                    index++;
                    nums[index] = nums[i];
                }
            }
            return index + 1;
        }

        // 189. Rotate Array

        // Solution #1: traver array k times,
        // move the last element on place from k - 1 to k - 2, k - 3, ..., 1, 0
        // Result check: time limit exeeded when array and k are bigger
        public static void RotateS1(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 1) return;

            for (int i = 0; i < k; i++)
            {
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    int temp = nums[j];
                    nums[j] = nums[j - 1];
                    nums[j - 1] = temp;
                }
            }
        }

        // Solution #2: Copy elements twice using one more array
        // Result check: it is correct.
        public static void RotateS2(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 1) return;

            int[] ex = new int[nums.Length];
            k = k % nums.Length; // Take modulo when k > array's length

            for (int i = 0; i <= nums.Length - 1 - k; i++)
            {
                ex[i + k] = nums[i];
            }

            for (int i = 0; i < k; i++)
            {
                ex[i] = nums[nums.Length + i - k];
            }

            // Copy elements in ex to the original array
            for (int i = 0; i < ex.Length; i++)
            {
                nums[i] = ex[i];
            }
        }

        // Solution #3: Don't use extra array
        public static void RotateS3(int[] nums, int k)
        {
            int len = nums.Length;
            if (k == 0 || len == 1) return;

            k = k % len;

            // Reverse the whole array
            MyUtils.ReverseArray(nums, 0, len - 1);

            // Reverse an sub-array from 0 to k - 1
            MyUtils.ReverseArray(nums, 0, k - 1);

            // Reverse an sub-array from n - k to n - 1;
            MyUtils.ReverseArray(nums, k, len - 1);
        }

        // 217. Contains Duplicate - Easy
        // Solution #1: traverse the array since the second element and compare it with the first element
        // repeat the step above
        // Check results: except for time limit exeeded, all is good
        public static bool ContainsDuplicateS1(int[] nums)
        {
            if (nums.Length == 1) return false;


            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) return true;
                }
            }

            return false;
        }

        // Solution #2: reduce time complexity from o(n^2) to o(n) using dicitonary
        public static bool ContainsDuplicateS2(int[] nums)
        {
            if (nums.Length == 1) return false;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (dict.ContainsKey(i)) return true;
                dict.Add(i, 1);
            }

            return false;
        }

        // Solution #3: reduce time complexity using HashSet
        public static bool ContainsDuplicateS3(int[] nums)
        {
            if (nums.Length == 1) return false;

            HashSet<int> set = new HashSet<int>();

            foreach (int i in nums)
            {
                if (!set.Add(i)) return true;
            }

            return false;
        }

        // 136. Single Number - Easy
        // Tips:
        // 1. Requirements: You must implement a solution with a linear runtime complexity and use only constant extra space.
        // 2. Consider: firstly create a dictionary to add all element, then traverse the dictionary to find the unique element
        // Check result: Implement a solution with:
        // Linear runtime complexity ✅ (your code is O(n))
        // Only constant extra space ❌ (your code uses a Dictionary, which is O(n) space)
        public static int SingleNumberS1(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Create a dictionay with the array
            foreach (int i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            // Search the unique element
            foreach (var pair in dict)
            {
                if (pair.Value == 1) return pair.Key;
            }

            return -1;
        }

        public static int SingleNumberS2(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int result = 0;

            foreach (int i in nums)
            {
                result ^= i;
            }

            return result;
        }

        // 66. Plus One
        // Tips for solution #1:
        // 1. Consider the number is 9 in current position
        // 2. Traverse the array reversely
        // 3. How do I store a result?
        public static int[] PlusOneS1(int[] digits)
        {
            int len = digits.Length;
            int carry = 1;

            if (len == 1)
            {
                if (digits[0] == 9)
                {
                    int[] newArr = new int[len + 1];
                    newArr[0] = carry;
                    newArr[1] = 0;
                    return newArr;
                }

                digits[0] = digits[0] + carry;
                return digits;
            }

            for (int i = len - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] = digits[i] + carry;
                    carry = 0;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
                if (i == 0 && digits[i] == 0 && carry == 1) // Deal the most significant
                {
                    int[] newArr = new int[len + 1];

                    digits.CopyTo(newArr, 1);
                    newArr[0] = carry;
                    return newArr;
                }
            }

            return new int[len];
        }

        // Solution #2: Make the solution #1
        public static int[] PlusOneS2(int[] digits)
        {
            int carry = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                digits[i] = sum % 10;
                carry = sum / 10;
            }

            if (carry == 1)
            {
                int[] newArr = new int[digits.Length + 1];
                newArr[0] = carry;
                return newArr;
            }

            return digits;
        }

        // 283. Move Zeroes
        // Requirements: Note that you must do this in-place without making a copy of the array.
        // Tips of solution #1
        // Consider creating a pointer to store indexes non-zero elements
        // Check result: the logic is not neat
        public static void MoveZeroesS1(int[] nums)
        {
            int len = nums.Length;

            if (len == 1) return;

            int left = 0; // Pointer to traverse the array
            int store = 0; // Pointer to store non-zero elements

            while (left < len)
            {
                if (left == 0 && nums[left] != 0)
                {
                    store++;
                }
                else if (nums[left] != 0)
                {
                    if (left == len - 1 && store == len - 1)
                    {
                        return;
                    }
                    int temp = nums[store];
                    nums[store] = nums[left];
                    nums[left] = temp;
                    store++;
                }

                left++;
            }
        }

        // Solution 2
        // Check result: 
        public static void MoveZeroesS2(int[] nums)
        {
            int len = nums.Length;

            if (len == 1) return;

            int store = 0;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] != 0)
                {
                    if (i != store)
                    {
                        int temp = nums[store];
                        nums[store] = nums[i];
                        nums[i] = temp;
                    }

                    store++;
                }
            }
        }

        // 349. Intersection of Two Arrays
        // Tips:
        // 1. Consider implement it using HashSet
        // 2. Consider test cases
        // 3. Time and memory complexity
        // Check result and feedback is listed
        // . Redundant Contains() checks:
        // . No need to check if (set1.Contains(i)) before adding — HashSet.Add() already ensures uniqueness.
        // Over-complicated logic for choosing the smaller set:
        // This optimization doesn't help significantly in this case and makes the code harder to read.
        // . Return [-1] is not required. -> Need to confirm it with the interviewer.
        public static int[] IntersectionS1(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            // Create a set to store key and its count for array 1
            foreach (int i in nums1)
            {
                if (set1.Contains(i))
                {
                    continue;
                }
                set1.Add(i);
            }

            // Create another set for array 2
            foreach (int i in nums2)
            {
                if (set2.Contains(i))
                {
                    continue;
                }
                set2.Add(i);
            }

            // Select the small set and traverse it and compare its element with another
            int[] result;
            int left = 0;

            if (set1.Count < set2.Count)
            {
                result = new int[set1.Count];

                foreach (int i in set1)
                {
                    if (set2.Contains(i))
                    {
                        result[left] = i;
                        left++;
                    }
                }
            }
            else
            {
                result = new int[set2.Count];

                foreach (int i in set2)
                {
                    if (set1.Contains(i))
                    {
                        result[left] = i;
                        left++;
                    }
                }
            }
            if (left == 0)
            {
                return [-1];
            }
            return result;
        }

        // Optimize the solution above
        public static int[] IntersectionOpt(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> result = new HashSet<int>();

            foreach (int i in nums2)
            {
                if (set1.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

        // 350. Intersection of Two Arrays II
        // Tips:
        // 1. Consider it implements using dictionary
        // 2. Create a dictionary using array 1
        // 3. Traverse another array and add common elements to dictionay result
        // 4. Convert the result to an array
        public static int[] Intersect2S1(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            //Dictionary<int, int> result = new Dictionary<int, int>();
            List<int> result = new List<int>();

            // Create a dictionary using array 1
            foreach (int i in nums1)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            foreach (int i in nums2)
            {
                if (dict.ContainsKey(i))
                {
                    result.Add(i);
                    // Update dictionary to remove the key
                    if (dict[i] <= 1)
                    {
                        dict.Remove(i);
                    }
                    else
                    {
                        dict[i]--;
                    }
                }
            }

            // Covert dictionary result to an array
            return result.ToArray();
        }

        // 121. Best Time to Buy and Sell Stock
        // Tips:
        // 1. Requirements: Selling on day one is not allowed
        // Check result: the solution is correct but inefficient
        public static int MaxProfit(int[] prices)
        {
            int len = prices.Length;
            int max = 0;

            if (len == 1)
            {
                return max;
            }

            // Select one day to buy a stock, then traverse the rest elements
            // Compare this element with the max
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > max)
                    {
                        max = profit;
                    }
                }
            }
            return max;
        }

        // Solution #2: reduce the time complixity from o(n^2) to o(n)
        public static int MaxProfitOpt(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int p in prices)
            {
                // Replace minimum price with current price
                // if current price is less than minimum price
                if (p < minPrice)
                {
                    minPrice = p;
                }

                // Calculate current profit and compare it with maximum profit
                if (p - minPrice > maxProfit)
                {
                    maxProfit = p - minPrice;
                }
            }
            return maxProfit;
        }

        // 122. Best Time to Buy and Sell Stock II -> Need to review!!!
        // Tips
        // The goal is to accumulate profit from every increasing price segment.
        public static int MaxProfitII(int[] prices)
        {
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    // Sell stock when prices[i] is greater than prices[i-1]
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }

        // 541. Reverse String II
        // Tips:
        // 1. Consider how do you create a new string
        // 2. For the last k-interval subdivision, select minimun of the right and len
        public static string ReverseStr(string s, int k)
        {
            // Convert string to char[]
            char[] chars = s.ToCharArray();

            // Seperate sub arrays using interval arry.len / k + 1
            // Reverse those sub arrays in 1k, 3k, ...
            for (int i = 0; i <= chars.Length / k; i++)
            {
                int left = i * k + 0;
                int right = Math.Min(i * k + k - 1, chars.Length - 1);

                // Revert first k chars
                if ((i + 1) % 2 != 0)
                {
                    while (left < right)
                    {
                        char temp = chars[left];
                        chars[left] = chars[right];
                        chars[right] = temp;
                        left++;
                        right--;
                    }
                }
            }
            return new string(chars);
        }

        // Solution #2: 
        // Tips:
        // 1. For statement is concise
        public static string ReverseStrOpt(string s, int k)
        {
            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i += 2 * k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, chars.Length - 1);

                while (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(chars);
        }

        // 242. Valid Anagram - Easy
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            // Create a dictionary using first s
            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            foreach (char c in s) 
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            // Compare each element in the second s and update the dictionary
            // true if the dictionary is empty after traverse is over
            foreach (char c in t)
            {
                if (dict.ContainsKey(c))
                {
                    if (dict[c] == 1)
                    {
                        dict.Remove(c);

                    } else 
                    {
                        dict[c]--;
                    }
                }
                else
                {
                    return false;
                }
            }

            //return dict.Count == 0 ? true : false;
            return dict.Count == 0; // Optimize the final return statement
        }

        // 387. First Unique Character in a String
        // Solution #2: consider replace dictionary with integer array int[26]
        // Key points: freq[i - 'a']
        public static int FirstUniqChar(string s)
        {
            // Create a dictionary using a string
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dict.ContainsKey(c)) 
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            // Traverse this string and check its value per key
            //foreach (char c in s)
            //{
            //    if (dict.ContainsKey(c) && dict[c] == 1)
            //    {
            //        return s.IndexOf(c);
            //    }
            //}

            // Optimize block above
            for (int i  = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        // 125. Valid Palindrome
        // Tips
        // constraint: s consists only of printable ASCII characters.
        // Consider there are two pointers left and right, and then compare those two chars
        // Need to lowercase char before comparing two chars
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right) 
            {
                // Move two pointers
                while (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                // Lowercase char
                char l = s[left];
                char r = s[right];

                if (char.IsLetter(l))
                {
                    l = char.ToLower(l);
                }

                if (char.IsLetter(r))
                {
                    r = char.ToLower(r);
                }

                // Compare left and right
                
                if (l != r) 
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        // Solution #2: Make code concise and add left < right in inner while statements
        public static bool IsPalindromeRef(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Move two pointers
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                // Compare left and right

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        // No # Implement strStr()
        public static int StrStr(string haystack, string needle)
        {
            int partLen = needle.Length;
            int wholeLen = haystack.Length;

            if (partLen > wholeLen) 
            { 
                return -1; 
            }
            
            // Traver needle's length each time
            for (int i = 0; i <= wholeLen - partLen; i++) 
            {
                if (haystack.Substring(i, partLen) == needle ) 
                {  
                    return i; 
                }
            }

            return -1;
        }

        // Solution #2:
        public static int StrStrS2(string haystack, string needle)
        {
            int n = haystack.Length;
            int m = needle.Length;

            if (m > n) return -1;

            for (int i = 0; i <= n - m; i++)
            {
                int j = 0;
                while (j < m && haystack[i + j] == needle[j])
                {
                    j++;
                }

                if (j == m)
                {
                    return i;
                }
            }

            return -1;
        }

        // 14. Longest Common Prefix
        // Tips:
        // Understand meaning of the word prefix
        // Check result: the solution cause a critial flaw: there is a string is shorter than the first string
        public static string LongestCommonPrefix(string[] strs)
        {
            StringBuilder sb = new StringBuilder();

            // Select the first string as comparison
            // Traver the rest strings and compare each elements with the first string
            for (int i = 0; i < strs[0].Length; i++) 
            {
                for (int j = 1; j < strs.Length; j++) // Select the next string until traverse the end of array
                {
                    if (strs[0].Substring(i, 1) != strs[j].Substring(i,1))
                    {
                        return sb.ToString();
                    }
                }
                sb.Append(strs[0].Substring(i,1));
            }

            return sb.ToString();
        }

        // Solution #2:
        // Optimize following things:
        // . Fix the critial flow mentioned above
        // . Reduce memory complexity
        public static string LongestCommonPrefixRef(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            // Select first string as the object for comparison
            // Then traverse the first string and compare
            for (int i = 0; i < strs[0].Length; i++)
            {
                // Traverse the rest and compare each char with that of first string 
                for (int j = 1; j < strs.Length; j++)
                {
                    // Consider the rest is shorter than the first
                    if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0]; // Return the first string
        }

        // 8. String to Integer (atoi)
        // Tips:
        // Clarify: white space definition including ' ', \n, \t
        // Result check: it is not correct for some scenarios
        public static int MyAtoi(string s)
        {
            int result = 0;
            int sign = 1;

            if (string.IsNullOrEmpty(s)) return 0;

            foreach (char c in s)
            {
                // Deal with leading white space
                if (char.IsWhiteSpace(c) && result == 0) continue;
                if (char.IsWhiteSpace(c) && result != 0) break;

                // Deal with +
                if (c == '+' && result == 0) // + is in leading position
                {
                    sign = 1;
                    continue;
                }
                if (c == '+' && result != 0) break; // + is not in leading position

                // Deal with -
                if (c == '-' && result == 0)
                {
                    sign = -1;
                    continue;
                }
                if (c == '-' && result != 0) break;

                // Deal with 0-9
                if (c - '0' >= 0 && c - '0' <= 9)
                {
                    if (result * sign >= int.MaxValue) return int.MaxValue;
                    if (result * sign <= int.MinValue) return int.MinValue;

                    result = result * 10 + c - '0';
                }

                // Deal with a-z or A-Z or .
                if ((c - 'a' >= 0 && c - 'z' < 26) || (c - 'A' >= 0 && c - 'Z' < 26) || c == '.') break;
            }

            return result * sign;
        }

        // Solution #2:
        // Tips:
        // Here're highlights compared to the solution #1
        // Process: leading whitespaces -> possible sign -> process digits
        // Char is implemented using U-16bits in class Char, Make statement like if you want to get its vlaue
        // char - '0' -> Get int of number 0-9
        // char - 'a' -> Get int of lowercase letter a-z
        // Some APIs:
        // Char.IsDigit(char).
        // Char.IsWhiteSpace(char)
        // String.IsNullOrEmpty(str) -> check for the string is empty or null,
        // don't add statement like s == null
        // Convert char to number: check overflow before adding digit.
        // Implement logic: result = result * 10 + new digit
        public static int MyAtoiRef(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int i = 0;
            int result = 0;
            int sign = 1;

            // Skip leading whitespaces
            while (i < s.Length && char.IsWhiteSpace(s[i]))
            {
                i++;
            }

            // Check for optional sign only once
            if (i < s.Length && (s[i] == '+' || s[i] == '-'))
            {
                sign = (s[i] == '-') ? -1 : 1;
                i++;
            }

            // Process digits
            while (i < s.Length && char.IsDigit(s[i]))
            {
                // Check overflow before adding digit
                int digit = s[i] - '0';

                if (sign == 1 && (result * sign> int.MaxValue / 10
                    || result * sign == int.MaxValue / 10 && digit > 7)) return int.MaxValue;

                if (sign == -1 && (result * sign < int.MinValue / 10
                    || result * sign == int.MinValue / 10 && digit * sign < -8)) return int.MinValue;

                result = result * 10 + digit;
                i++;
            }

            return result * sign;
        }


        #region "List problems"

        // #19. Remove Nth Node From End of List
        // Check result: for this scenario: [1, 2], n = 2, it doesn't work
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode curr = head;
            
            if (curr.Next == null && n == 1)
            {
                return null;
            }

            int len = 0;
            // Traverse list first time to count its length
            while (curr != null)
            {
                len++;
                curr = curr.Next;
            }

            // Traverse again to find length - n node
            curr = head; // Reset curr with head
            int i = 0;
            while (curr.Next != null) 
            {
                if (i == len - 1 - n && curr.Next.Next != null)
                {
                    curr.Next = curr.Next.Next;
                    return head;
                }
                if (i == len - n && curr.Next.Next == null)
                {
                    head = curr.Next;
                    return head;
                }
                i++;
                curr = curr.Next;
            }
            return head;
        }

        // Solution #2
        public static ListNode RemoveNthFromEndRef(ListNode head, int n)
        {
            ListNode start = new ListNode(0);
            start.Next = head;

            ListNode fast = start;
            ListNode slow = start;

            // Move fast pointers
            for (int i = 0; i <= n; i++) 
            {
                fast = fast.Next;
            }

            // Move both pointers
            while (fast != null) 
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            slow.Next = slow.Next.Next;

            return start.Next;
        }
        // #237. Delete Node in a Linked List
        public static void DeleteNode(ListNode node)
        {

        }
    }
    #endregion
    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }

        // Add a new node in the end of the list
        public void AddNodeTrail(int val)
        {
            ListNode node = new ListNode(val);
            ListNode curr = this; // Get the list head

            while (curr.Next != null) 
            {
                curr = curr.Next;
            }

            curr.Next = node;
        }
    }
}