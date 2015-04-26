using System;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Use WhileApp v0.1");

            string command;
            do
            {
                Console.Write(">");
                command = Console.ReadLine();
                switch(command)
                {
                    case "get":
                        doGet();
                        break;
                    case "put":
                        doPut();
                        break;
                    case "exit":
                        break;
                    default:
                        doDefault();
                        break;
                }
            }
            while (command != "exit");
        }

        private static int doGet()
        {
            Console.WriteLine("GetFile...OK");
            return 0;
        }

        private static int doPut()
        {
            Console.WriteLine("PutFile...OK");
            return 0;
        }

        private static int doDefault()
        {
            Console.WriteLine("Command Error");
            Console.WriteLine("WhileApp v 0.1 Support Command");
            Console.WriteLine("\tget:\tGetFile");
            Console.WriteLine("\tput:\tPutFile");
            Console.WriteLine("\tExit:\tExitApp");
            return 0;
        }
    }
}
