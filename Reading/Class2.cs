using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Reading.Models;

namespace Reading
{
    public static class Class2
    {
        public static void GetTXTList()
        {
            string[] s = File.ReadAllLines("test04.TXT");
            foreach (var word in s)
            {
                SetList(word);
            }
        }
        public static void SetList(string word)
        {
            string checkticknumber = string.Empty;
            string ticknumber = string.Empty;
            string flyingDay = string.Empty;
            string birthDay = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (i <= 12)
                {
                    if (i < 3)
                    {
                        checkticknumber = checkticknumber + word[i];
                    }
                    ticknumber = ticknumber + word[i].ToString();
                }
                else if (i <= 20)
                {
                    flyingDay = flyingDay + word[i].ToString();
                }
                else
                {
                    birthDay = birthDay + word[i].ToString();
                }
            }
            CheckTxt(checkticknumber, ticknumber, flyingDay, birthDay);
        }
        public static void CheckTxt(string checkticknumber,string ticknumber, string flyingDay,string birthDay)
        {
            if (checkticknumber == "695" || checkticknumber == "525")
            {
                DateTime d1, d2;
                if (flyingDay == "99999999")
                {
                    d1 = DateTime.MaxValue;
                }
                if (birthDay == "99999999")
                {
                    d2 = DateTime.MaxValue;
                }
                if (DateTime.TryParseExact(flyingDay, "yyyyMMdd", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces, out d1) && DateTime.TryParseExact(birthDay, "yyyyMMdd", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces, out d2))
                {
                    CreateData(ticknumber, d1, d2);
                }
            }
        }
        public static void CreateData(string ticknumber,DateTime d1,DateTime d2)
        {
            ReadingModel context = new ReadingModel();
            ReadingTable readingTable = new ReadingTable()
            {
                TickNumber = ticknumber,
                FlyingDay = d1,
                Birthday = d2
            };
            context.ReadingTable.Add(readingTable);
            context.SaveChanges();
        }
    }
}
