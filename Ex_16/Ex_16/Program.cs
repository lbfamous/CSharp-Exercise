using System;
using System.IO;


namespace Ex_16
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsMyfile = new FileStream("myfile.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter swMyfile = new StreamWriter(fsMyfile);
            swMyfile.WriteLine("Hello World");
            swMyfile.WriteLine("abcdefghijklmnopqrstuvwxyz");
            swMyfile.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            swMyfile.WriteLine("0123456789");
            swMyfile.Flush();

            StreamReader srMyfile = new StreamReader(fsMyfile);
            srMyfile.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine("****************************Read File Text Mode ***************************");

            string s1;
            while((s1 = srMyfile.ReadLine()) !=null)
            {
                Console.WriteLine(s1);
            }
            Console.WriteLine();

            BinaryReader brMyfile = new BinaryReader(fsMyfile);
            brMyfile.BaseStream.Seek(0, SeekOrigin.Begin);

            Console.WriteLine("***********************Read File :Binary Mode*****************************");
            Byte b1;
            while(brMyfile.PeekChar()>-1)
            {
                b1 = brMyfile.ReadByte();
                if(b1 != 13 && b1 != 10)
                {
                    Console.Write("{0}", b1.ToString());
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            brMyfile.Close();
            //swMyfile.Close();
            srMyfile.Close();
            fsMyfile.Close();

            Console.WriteLine("**********************Read File Info***************************");

            FileInfo fiMyfile = new FileInfo("myfile.txt");
            Console.WriteLine("FileName:      {0}", fiMyfile.Name);
            Console.WriteLine("FileName(Full):{0}", fiMyfile.FullName);
            Console.WriteLine("FileSize:      {0}", fiMyfile.Length);
            Console.WriteLine("CreateTime:    {0}", fiMyfile.CreationTime);

            Console.ReadLine();
        }
    }
}
