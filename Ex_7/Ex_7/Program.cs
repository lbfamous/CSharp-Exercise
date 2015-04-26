using System;
using System.IO;


namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三种型号： 1 = (Mini) ,2= (Mid),3 = (BIG)");
            Console.WriteLine("You Choice:");

            string s = Console.ReadLine();
            int n = int.Parse(s);

            switch(n)
            {
                case 1:
                    Console.WriteLine("Mini");
                    break;
                case 2:
                    Console.WriteLine("Mid");
                    break;
                case 3:
                    Console.WriteLine("BIG");
                    break;
                default:
                    Console.WriteLine("Mid,pay please");
                    break;
            }

            Console.WriteLine("You are welcome ByeBye");
            Console.ReadLine();

        }
    }
}
