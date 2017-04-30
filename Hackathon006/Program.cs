using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一組數字：");

            string input = Console.ReadLine();
            string[] led = new string[]
            {
                " _     _  _     _  _  _  _  _ ",
                "| |  | _| _||_||_ |_   ||_||_|",
                "|_|  ||_  _|  | _||_|  ||_| _|"
            };
            string led0 = "";
            string led1 = "";
            string led2 = "";

            int i = 0; 
            bool result = int.TryParse(input, out i);

            if (result != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("輸入錯誤，" + input + "不是一組數字。");
                Console.ReadLine();
                return;
            }

            foreach (char str in input)
            {
                led0 = led[0].Substring(int.Parse(str.ToString()) * 3, 3);

                Console.Write(led0);
            }
            Console.WriteLine();
            foreach (char str in input)
            {
                led1 = led[1].Substring(int.Parse(str.ToString()) * 3, 3);

                Console.Write(led1);
            }
            Console.WriteLine();
            foreach (char str in input)
            {
                led2 = led[2].Substring(int.Parse(str.ToString()) * 3, 3);

                Console.Write(led2);
            }
            Console.ReadLine();
        }
    }
}
