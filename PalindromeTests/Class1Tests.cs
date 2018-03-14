using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void String_121_is_Palindrome()
        {
            string s = "121";
            bool check = Class1.CheckPalindrome(s);
            Assert.AreEqual(true, check);
        }
    }
}