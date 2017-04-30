using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackathon003
{
    class Program
    {
        public static void Main(string[] args)
        {
            Palindrome text = new Palindrome();
            Console.Write("請輸入文字：");
            string test = Console.ReadLine();
            Console.WriteLine(text.Check(test).ToString());
            Console.ReadLine();
        }      
    }
    public class Palindrome
    {
        public bool Check(string text)
        {
            Char[] reversed = text.Reverse().ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (char chr in reversed)
            {
                sb.Append(chr);
            }
            string s = sb.ToString();

            if (s == text) { return true; }
            else { return false; }
        }
    }
}
