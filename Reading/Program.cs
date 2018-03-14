using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Reading.Models;

namespace Reading
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2.GetTXTList();
            ReadingModel readingModel = new ReadingModel();
            List<ReadingTable> list = readingModel.ReadingTable.ToList();
            foreach(var index in list)
            {
                Console.WriteLine($"{index.TickNumber} : {index.FlyingDay.ToShortDateString()} : {index.Birthday.ToShortDateString()}");
            }
            Console.ReadLine();
        }
    }
}
