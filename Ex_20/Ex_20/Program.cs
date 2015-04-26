using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ex_20 虚方法
namespace Ex_20
{
    class Area
    {
        public class Geometry
        {
            public const double pi = Math.PI;
            protected double r;

            public Geometry() 
            {

            }

            public Geometry(double x)
            {
                r = x;
            }

            public virtual double Area()
            {
                return r * r;
            }

        }

        public class Circle:Geometry
        {
            public Circle(double r):base(r)
            {

            }

            public override double Area()
            {
                return pi * r * r;
            }
        }

        public class Sphere:Geometry
        {
            public Sphere(double r):base(r)
            {

            }

            public override double Area()
            {
                return 4 * pi * r * r;
            }
        }

        public class EquilateralTriangle:Geometry
        {
            public EquilateralTriangle(double r):base(r)
            {

            }

            public override double Area()
            {
                return r * r * Math.Sin(pi / 3.0) / 2.0;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            double r = 4.0;
            Area.Geometry a = new Area.Geometry(r);
            Area.Geometry C = new Area.Circle(r);
            Area.Geometry s = new Area.Sphere(r);
            Area.Geometry et = new Area.EquilateralTriangle(r);

            Console.WriteLine("r = {0}, And The", r);
            Console.WriteLine("正方形 Area {0}", a.Area());
            Console.WriteLine("Circle Area {0}", C.Area());
            Console.WriteLine("Sphere Area {0}", s.Area());
            Console.WriteLine("Trial Area  {0}", et.Area());
        }
    }
}
