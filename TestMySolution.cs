namespace MyTry
{
    public class TestClass
    {
        public static void Main(string[] args)
        {

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
    }
}
