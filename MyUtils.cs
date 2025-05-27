using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTry
{
    public static class MyUtils
    {
        // Helper function to create a dictionary<char, int> using a string
        public static Dictionary<char, int> CreateMaterialDictionary(string m)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in m)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }
            return dict;
        }

        // Reverse an array
        public static int[] ReverseArray(int[] arr, int left, int right)
        {
            if (arr.Length < 2)
            {
                return arr;
            }

            while (left < right) 
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            return arr;
        }

        // Helper to print char[]
        public static void Printer(char[] s)
        {
            foreach (char c in s)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        // Print an int array
        public static void PrinterIntArr(int[] arr)
        {
            Console.Write("[");

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ",");
                }
            }

            Console.Write("]");
            Console.WriteLine();
        }

        public static void PrintListNode(ListNode head)
        {
            ListNode node = head;

            while (node!= null) // Not node.Next != null
            {
                Console.Write($"{node.Val} ");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
