using System;


namespace Palindrome
{
    class Program   
    {
        public static void Main()
        {
            while(true)
            {
                Console.WriteLine("Type a string to check it for palindrome, type 'quit' to exit the program");
                var s = Console.ReadLine();
                if (s == "quit")
                {
                    return;
                }
                if (Checker.PalindromeChecker(s))
                {
                    Console.WriteLine("The string is palindrome");
                }
                else
                {
                    Console.WriteLine("The string isn`t palindrome");
                }

            }
        }
    }
}
