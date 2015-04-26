using System;
using System.Text;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue1, intValue2;
            long longValue1, longValue2;
            intValue1 = 123;
            longValue1 = 456;
            longValue2 = intValue1;
            intValue2 = (int)longValue1;
            Console.WriteLine("(long){0} = {1}", intValue1, longValue2);
            Console.WriteLine("(int){0} = {1}", longValue1, intValue2);

            //- 
            long longValue3 = 2147483657L;
            int intValue3 = (int)longValue3;
            Console.WriteLine("(int){0} = {1}", longValue3, intValue3);
        }
    }
}
