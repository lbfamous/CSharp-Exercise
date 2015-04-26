using System;
using System.IO;

//- Ex_17 简单的类

namespace Ex_17
{

    public class Person
    {
        public enum Sex : byte
        {
            Male = 0,
            Female,
        }

        //私有属性
        private string name;
        private Sex sex;
        private byte age;
        private float height;
        private float weight;

        public Person(string sName)
        {
            name = sName;
        }

        public Person(string sName, Sex cSex)
        {
            name = sName;
            sex = cSex;
        }

        public void setAge(byte bAge)
        {
            age = bAge;
        }

        public void setSex(Sex cSex)
        {
            sex = cSex;
        }

        public void setSex(byte bSex)
        {
            sex = (Sex)bSex;
        }

        public void setHeight(float fHeight)
        {
            height = fHeight;
        }

        public void setWeight(float fWeight)
        {
            weight = fWeight;
        }

        public string getName()
        {
            return name;
        }

        public byte getAge()
        {
            return age;
        }

        public Sex getSex()
        {
            return sex;
        }

        public float getHeigh()
        {
            return height;
        }

        public float getWeight()
        {
            return weight;
        }

    }
}


namespace Ex_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Green Manu");
            p1.setSex((byte)1);
            p1.setAge(19);
            p1.setHeight((float)1.68);
            p1.setWeight(45);

            Person p2 = new Person("Blue Tim", 0);
            p2.setAge(25);
            p2.setHeight((float)1.75);
            p2.setWeight(74);

            Console.WriteLine("{0}\t{1}\t{2}\t{4}", p1.getName(), p1.getSex(), p1.getAge(), p1.getHeigh(), p1.getWeight());
            Console.WriteLine("{0}\t{1}\t{2}\t{4}", p2.getName(), p2.getSex(), p2.getAge(), p2.getHeigh(), p2.getWeight());

            Console.ReadLine();

        }
    }
}
