using System;

namespace Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome WhileApp V0.1");
            Console.Write(">");

            string command;
            while((command = Console.ReadLine())!= "exit")
            {
                switch(command)
                {
                    case "get":
                        doGet();
                        break;
                    case "put":
                        doPut();
                        break;
                    default:
                        doDefault();
                        break;
                }
                Console.Write(">");
            }            
        }

        public static int doGet()
        {
            Console.WriteLine("Get File...OK");
            return 0;
        }

        public static int doPut()
        {
            Console.WriteLine("Put File...OK");
            return 0;
        }

        public static int doDefault()
        {
            Console.WriteLine("Command Error");

            Console.WriteLine("WhileApp v0.1 Supprt Command");
            Console.WriteLine("\tget:\t Get File");
            Console.WriteLine("\tput:\t Put File");
            Console.WriteLine("\texit:\t Exit App");
            return 0;
        }
    }
}
