using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-枚举类型
namespace Ex_14
{
    class Program
    {
        public enum Weekday
        {
            Sun,Mon,Tue,Wed,Thu,Fri,Sai
        }

        public static Weekday NextDay(Weekday wd)
        {
            Weekday wdnext;
            if(wd == Weekday.Sai)
            {
                wdnext = Weekday.Sun;
            }
            else 
            {
                wdnext = wd + 1;
            }

            return wdnext;
        }

        static void Main(string[] args)
        {
            Weekday wd1 = Weekday.Mon;
            Console.WriteLine("Every Day Work Start at {0}", wd1);
            Weekday wd2 = Weekday.Fri;
            Console.WriteLine("Ends at {0}", wd2);
            Console.WriteLine("Every Week have {0} work days", wd2 - wd1);
            Console.WriteLine();

            foreach (string s1 in Weekday.GetNames(typeof(Weekday)))
            {
                Console.Write(s1 + " ");
            }

            Console.WriteLine();

            Console.WriteLine("what's the day today");

            Weekday wd3 = (Weekday)Weekday.Parse(typeof(Weekday), Console.ReadLine());
            Console.WriteLine("tomorrow is {0}", NextDay(wd3));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
