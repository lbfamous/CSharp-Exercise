using System;
using System.Collections;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary environment = Environment.GetEnvironmentVariables();
            Console.WriteLine("EnvironmentVars\t=\t EnvironmentValue");

            foreach(string environmentKey in environment.Keys)
            {
                Console.WriteLine("{0}\t=\t{1}", environmentKey, environment[environmentKey].ToString());
            }

            Console.ReadLine();
        }
    }
}
