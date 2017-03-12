
namespace Palindrome
{
    sealed class Checker
    {
        public static bool PalindromeChecker(string s)
        {
            if (s == null)
            {
                return false;
            }
            var min = 0;
            var max = s.Length - 1;
            while (min <= max)
            {
                while (IsDelimiter(s[min]) && (min <= max))
                {
                    ++min;
                }
                while (IsDelimiter(s[max]) && (min <= max))
                {
                    --max;
                }
                if (char.ToLower(s[min]) != char.ToLower(s[max]) && (min <= max))
                {
                    return false;
                }
                ++min;
                --max;
            }
            return true;
        }

        private const string ignore = " _,.:;!?-()\"\'";
        private static bool IsDelimiter(char a)
        {
            return ignore.Contains(a.ToString());
        }
    }
}
