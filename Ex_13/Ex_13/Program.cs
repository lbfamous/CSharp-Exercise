using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//- 数组的数组，锯齿形数组
namespace Ex_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[2][];
            myArray[0] = new int[5] { 1, 3, 5, 7, 9 };
            myArray[1] = new int[4] { 0, 2, 4, 6 };
            for(int i = 0;i <myArray.Length;++i)
            {
                Console.Write("Array{0}: ", i);
                for(int j = 0;j <myArray[i].Length;++j)
                {
                    Console.Write("{0} ", myArray[i][j]);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
