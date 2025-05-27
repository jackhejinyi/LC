namespace MyTry
{
    public static class SolutionReview
    {
        // 7. Reverse Integer
        // Tips: this value is great than 2^31-1
        // or less than -2^31 when reversing the number 
        public static int Reverse(int x)
        {
            int result = 0;

            while (x != 0) // Consider x is negative 
            {
                int rem = x % 10;
                x = x / 10;
                result = (result * 10 + rem);
                
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && rem > 7)) // Consider overflow
                {
                    return 0;
                }
                if (result < int.MinValue / 10 || (result == int.MinValue && rem < -8)) // Consider overflow
                {
                    return 0;
                } 
            }
            return result;
        }
    }
}
