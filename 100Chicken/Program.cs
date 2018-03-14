using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Chicken
{
    class Program
    {
        public static int totalmoney = 1000;
        public static int totalchieken = 100;
        public static int coun = 0;
        public static List<Number> list = new List<Number>()
        {
            new Number() { Price = 60,Need = 1,Dis = "x"},
            new Number() { Price = 30,Need = 1,Dis = "y"},
            new Number() { Price = 1,Need = 1,Dis = "z"}
        };
        public static List<Number> list1 = new List<Number>()
        {
            new Number() { Price = 1,Need = 1,Dis = "x"},
            new Number() { Price = 1,Need = 1,Dis = "y"},
            new Number() { Price = 1,Need = 1,Dis = "z"}
        };
        static void Main(string[] args)
        {
            Check();
            Find();
            Console.ReadLine();
        }
        public static void Find()
        {
            List<Number> newlist = new List<Number>();
            List<Number> newlist1 = new List<Number>();
            List<Number> newlist2 = new List<Number>();
            Number little = new Number();
            Number little1 = new Number();
            List<Number> ans = new List<Number>();
            List<Number> ans1 = new List<Number>();
            int[] a = new int[3];
            for(int i=0;i<3;i++)
            {
                a[i] = list[i].Price * list1[i].Price;
            }
            int min = a.Min((x) => x);
            for(int i=0;i<3;i++)
            {
                if((list[i].Price* list1[i].Price)==min)
                {
                    little = list[i];
                    little1 = list1[i];
                }
            }
            foreach(var index in list)
            {
                Number n = new Number()
                {
                    Price = index.Price * little1.Price,
                    Need = index.Need * little1.Price,
                    Dis = index.Dis
                };
                newlist.Add(n);
            }
            foreach (var index in list1)
            {
                Number n = new Number()
                {
                    Price = index.Price * little.Price,
                    Need = index.Need * little.Price,
                    Dis = index.Dis
                };
                newlist1.Add(n);
            }
            totalmoney = totalmoney * little1.Price;
            totalchieken = totalchieken * little.Price;
            for(int i=0;i<newlist.Count;i++)
            {
                Number n = new Number()
                {
                    Price = newlist[i].Price-newlist1[i].Price,
                    Need = newlist[i].Need,
                    Dis = newlist[i].Dis
                };
                if(n.Price!=0)
                {
                    newlist2.Add(n);
                }
            }
            int number = totalmoney - totalchieken;
            int count = 0;
            if(newlist2[0].Price>newlist2[1].Price)
            {
                count = number / newlist2[0].Price;
                for(int i=1;i<=count;i++)
                {
                    if((number-(newlist2[0].Price*i))%newlist2[1].Price==0)
                    {
                        Number n = new Number()
                        {
                            Price = newlist2[0].Price,
                            Need = i,
                            Dis = newlist2[0].Dis
                        };
                        Number n1 = new Number()
                        {
                            Price = newlist2[1].Price,
                            Need = (number - (newlist2[0].Price * i)) / newlist2[1].Price,
                            Dis = newlist2[1].Dis
                        };
                        ans.Add(n);
                        ans.Add(n1);
                    }
                }
            }
            for(int i=0;i<ans.Count;i=i+2)
            {
                Number n2 = new Number()
                {
                    Price = list[2].Price,
                    Need = totalchieken - (ans[i].Need * newlist1[0].Price) - (ans[i+1].Need * newlist1[1].Price),
                    Dis = list[2].Dis
                };
                ans1.Add(n2);
            }
            int j = 0;
            for(int i=0;i<ans.Count;i++)
            {
                Console.Write($"{ans[i].Dis} = {ans[i].Need} ");
                if(i%2==1)
                {
                    Console.Write($"{ans1[j].Dis} = {ans1[j].Need} ");
                    j++;
                }
            }
        }

        private static void Check()
        {
            int chicken1 = 1, chicken2 = 1, chicken3;
            while (true)
            {
                chicken3 = 100 - chicken1 - chicken2;
                if ((chicken1 * 60 + chicken2 * 30 + chicken3 * 1) == 1000)
                {
                    Console.WriteLine($"{chicken1.ToString()} : {chicken2.ToString()} : {chicken3.ToString()}");
                }
                if (++chicken2 > 33)
                {
                    chicken2 = 1;
                    chicken1++;
                }
                if (chicken1 > 20)
                {
                    break;
                }
            }
        }
    }
    public class Number
    {
        public int Price { get; set; }
        public int Need { get; set; }
        public string Dis { get; set; }
    }
}
