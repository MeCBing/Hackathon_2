using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>()
            {
                { '0', Class1.Zero },
                { '1', Class1.One },
                { '2', Class1.Two },
                { '3', Class1.Three },
                { '4', Class1.Four },
                { '5', Class1.Five },
                { '6', Class1.Six },
                { '7', Class1.Seven },
                { '8', Class1.Eight },
                { '9', Class1.Nine },
            };
            Console.Write("請輸入數字 : ");
            string s = Console.ReadLine();
            for(int i=0;i<3;i++)
            {
                foreach (var index in s)
                {
                    List<string> number = dictionary[index];
                    Console.Write($"{number[i]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
