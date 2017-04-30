using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon001
{
    class Program
    {
        static void Main(string[] args)
        {
            //寫一個簡單的程式，判斷 1~100 中有哪些數字是不
            //會被 3 整除，也不會被 5 整除的。
            for(int i = 1; i <= 100; i++)
            {
                var z = i % 3;
                var c = i % 5;
                if (z != 0 && c != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
