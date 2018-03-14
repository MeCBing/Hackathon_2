using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            for (int i = 101; i <= 200; i++)
            {
                b = true;
                for (int a = 2; a < i; a++)
                {
                    if (i % a == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if(b)
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
