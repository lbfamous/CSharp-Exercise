using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ex_4  predefine Types 

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this is a string";
            Console.WriteLine(str);
            string strCopy = string.Copy(str);
            Console.WriteLine(strCopy);

            bool testBool = (str == strCopy);
            Console.WriteLine("testBool is {0}", testBool);

            testBool = ((object)str == (object)strCopy);
            Console.WriteLine("testBool is {0}", testBool);

            float testfloat = 23456.23F;
            Console.WriteLine(testfloat);

            double testDouble = 23456.23;
            Console.WriteLine("testDouble is {0}", testDouble);


            testBool = (testfloat == testDouble);
            Console.WriteLine("testBool is {0}", testBool);


        }
    }
}
