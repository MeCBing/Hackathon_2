using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class Class1
    {
        public static bool CheckPalindrome(string s)
        {
            for(int i=0;i<(s.Length/2);i++)
            {
                if(s[i]!=s[s.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
