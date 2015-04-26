using System;

// for --> 
namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9 x 9 Table");

            for(int i = 1;i <= 9;i++)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    Console.Write("{0} × {1} = {2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
