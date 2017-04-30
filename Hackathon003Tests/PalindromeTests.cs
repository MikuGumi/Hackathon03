using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hackathon003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackathon003.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void Give_123_Expected_False_Test()
        {
            bool Expected = false;
            string give = "123";
            Palindrome text = new Palindrome();
            bool actual = text.Check(give);
            Assert.AreEqual(Expected, actual);
        }
        [TestMethod()]
        public void Give_12321_Expected_True_Test()
        {
            bool Expected = true;
            string give = "12321";
            Palindrome text = new Palindrome();
            bool actual = text.Check(give);
            Assert.AreEqual(Expected, actual);
        }
    }
}