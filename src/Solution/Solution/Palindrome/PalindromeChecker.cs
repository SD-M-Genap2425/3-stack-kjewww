using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            Stack<char> stack = new Stack<char>();
            string teks = new string(input.ToLower().Where(char.IsLetter).ToArray());

            foreach (char c in teks)
            {
                stack.Push(c);
            }

            foreach (char c in teks)
            {
                if (c != stack.Pop())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
