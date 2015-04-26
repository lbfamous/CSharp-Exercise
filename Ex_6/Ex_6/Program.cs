using System;

namespace Ex_6
{
    class Program
    {
        public static int Main(string[] args)
        {
             if(args.Length <1)
             {
                 Console.WriteLine("Usage: App char ");
                 return 1;
             }

             char letter = args[0][0];
             if(letter >= 'A')
             {
                 if(letter<= 'Z')
                 {
                     Console.WriteLine("{0} 是个大写字母", letter);
                     return 0;
                 }
             }

            if(letter >= 'a' && letter <= 'z')
            {
                Console.WriteLine("{0} 是个小写字母", letter);
                return 0;
            }

            if(Char.IsDigit(letter))
            {
                Console.WriteLine("{0} 是个数字",letter);
                return 0;
            }

            Console.WriteLine("{0} 是个特殊字符",letter);
            Console.ReadLine();

            return 0;
        }

        
    }
}
