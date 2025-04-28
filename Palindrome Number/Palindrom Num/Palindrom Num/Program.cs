public class Solution
{
    int x = 112211;
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        bool result = solution.IsPalindrome(solution.x);
        Console.WriteLine(result); 
    }
    public bool IsPalindrome(int x)
    {
        int reverse = 0;
        int original = x;
        while(x > 0)
        {
            int digit = x % 10;
            reverse = reverse * 10 + digit;
            x /= 10;
        }
        return original == reverse;
    }
}