namespace MyTry
{
    public static class MySolution
    {
        // 344. Reverse String - easy
        public static void ReverseString(char[] s)
        {
            if (s.Length == 1) return;
            
            for (int i = 0; i <= s.Length / 2 - 1 ; i++) 
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

    }
}
