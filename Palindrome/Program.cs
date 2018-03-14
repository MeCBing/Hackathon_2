using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入字串 : ");
            string s = Console.ReadLine();
            if(Class1.CheckPalindrome(s))
            {
                Console.WriteLine("這是回文");
            }
            else
            {
                Console.WriteLine("這不是回文");
            }
            Console.ReadLine();
        }
    }
}
