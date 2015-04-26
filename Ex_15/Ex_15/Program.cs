using System;

namespace Ex_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int varA = 10;
            int varB = 20;

            int andRet = varA & varB;
            Console.WriteLine("{0} & {1} = {2}", varA, varB, andRet);

            int orRet = varA | varB;
            Console.WriteLine("{0} | {1} = {2}", varA, varB, orRet);

            int norRet = varA ^ varB;
            Console.WriteLine("{0} ^ {1} = {2}", varA, varB, norRet);

            Console.WriteLine("~{0:x8} = {1:x8}", varA, ~varA);
            Console.WriteLine("{0:x8}>>3 = {1}", varA, varA >> 3);
            Console.WriteLine("{0:X8}<<3 = {1}", varA, varA << 3);

            Console.ReadLine();
        }
    }
}
