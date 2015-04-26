using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ex_18 操作符重载

namespace Ex_18
{

    class Rectangle
    {
        private int iHeight;
        private int iWidth;

        public int Width
        {
            get
            {
                return iWidth;
            }
            set
            {
                iWidth = value;
            }
        }

        public int Height
        {
            get
            {
                return iHeight;
            }
            set
            {
                iHeight = value;
            }
        }

        public int Area
        {
            get 
            {
                return Height * Width;
            }
        }

        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }

        public Rectangle(int w,int h)
        {
            Width = w;
            Height = h;
        }

        public static bool operator==(Rectangle a ,Rectangle b)
        {
            return ((a.Height == b.Height) && (a.Width == b.Width));
        }

        public static bool operator != (Rectangle a,Rectangle b)
        {
            return !(a == b);
        }

        public static bool operator > (Rectangle a ,Rectangle b)
        {
            return a.Area > b.Area;
        }
        public static bool operator <(Rectangle a ,Rectangle b)
        {
            return a.Area < b.Area;
        }

        public static bool operator >=(Rectangle a ,Rectangle b)
        {
            return (a > b) || (a == b);
        }

        public static bool operator<=(Rectangle a,Rectangle b)
        {
            return (a < b) || (a == b);
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Height = " + Height + "Width = " + Width;
        }

    //}

    //class Program
   // {
        public static void Main(string[] args)
        {

            Rectangle rc1 = new Rectangle();
            Rectangle rc2 = new Rectangle();
            Rectangle rc3 = new Rectangle(10, 15);

            rc1.Height = 15;
            rc1.Width = 10;
            rc2.Height = 25;
            rc2.Width = 10;

            Console.WriteLine("Rectangle #1" + rc1);
            Console.WriteLine("Rectangle #2" + rc2);
            Console.WriteLine("Rectangle #3" + rc3);

            if(rc1 == rc2)
            {
                Console.WriteLine("Rectangle #1 Equals #Rectangle #2");
            }
            else 
            {
                if(rc1 > rc2)
                {
                    Console.WriteLine("Rect 1 > Rect 2");
                }
                else
                {
                    Console.WriteLine("Rect1 < Rect2");
                }
            }

            if(rc1 == rc3)
            {
                Console.WriteLine("Rect1 == Rect3");
            }
            else
            {
                Console.WriteLine("Rect1 != Rect3");
            }


            Console.ReadLine();
        }
    }
}
