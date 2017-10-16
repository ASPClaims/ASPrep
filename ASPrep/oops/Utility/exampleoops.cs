using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oops.Utility
{
    public class exampleoops
    {
    }
    public class Aperture
    {
        protected double height = 5;
        protected double width = 10;
        protected double thickness = 15;
        public double get_volume()
        {
            double volume = height * width * thickness;
            if (volume < 0)
                return 0;
            return volume;
        }
    }
    // Inheritance
    public class ParentClass
    {
        string a;
        public ParentClass()
        {
            a= "Parent constructor";
        }
        public string msg1()
        {
            return a;
        }
    }
    public class ChildClass : ParentClass
    {
        string b;
        public ChildClass()
        {
            b= "child constructor";
        }
        public string msg2()
        {
            return b;
        }
       
    }


    //Abstract class

    abstract class absClass1
    {
        public abstract int AddNumbers(int a, int b);
        public abstract int MultiplyNumbers(int a, int b);
    }
    abstract class absClass2 : absClass1
    {
        public override int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
    class absDerived : absClass2
    {
        public override int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
    }

    //Encapsulation

    public class EnClass
    {
        private string a;
        public string EnClas
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }
    public class EnClass1
    {
        EnClass objEn = new EnClass();
       // string retVar;
        public string EnMethod()
        {
             objEn.EnClas = "Naresh";
             return objEn.EnClas;

        }
    }
    // polymorphism

    public class polyClass
    {
        public string add(string a, string b)
        {
            return a + b;
        }
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    public class derployClass
    {
        polyClass objPoly = new polyClass();
        public string addNames()
        {
          return objPoly.add("Naresh", "chikoti");
        }
        public int addNumb()
        {
            return objPoly.add(5,10);
        }
    }


    //public class getData
    //{
    //    Aperture obj = new Aperture();
    //    public static void main()
    //    {
    //        Aperture objAperture = new Aperture();
    //        double result = objAperture.get_volume();

    //    }
    //}
    
}