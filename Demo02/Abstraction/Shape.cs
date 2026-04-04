using Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP.Abstraction
{
    //interface IShape
    //{
    //    /// property Signature => property without implementation
    //    public double Dim010 { get; }
    //}

    //class squere1 : IShape
    //{
    //    public double Dim010 { get; set; }
    //}

    abstract class Shape
    {
        ///property implementation => property with implementation
        public double Dim01 { get; protected set; }
        public double Dim02 { get; protected set; }

        public abstract double Perimeter { get; } ///method not impemented => 
                                                  ///virtual method => a method that is declared in a base class and can be overridden in a derived class.

        /// abstract method => a method that is declared in an abstract class but 
        /// does not have an implementation.
        /// virtual method => a method that is declared in a base class and can be overridden in a derived class.
        public abstract double CalcArea();

        public virtual double CalcAreaImplmented()
        {
            return Dim01 + Dim02;
        }
    }

    abstract class rectshape : Shape
    {
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    class squere : rectshape
    {
        public squere(double Dim)
        {
            Dim01 = Dim02 = Dim;
        }

        //public double Dim01 { get; set; }

        public override double Perimeter { get { return Dim01 * 4; } }

        //public double Area { get { return Dim01 * Dim01; } } //drived property
        //public override double CalcArea()
        //{
        //    return Dim01 * Dim01;
        //}

    }

    class rectangle : rectshape
    {
        public rectangle(double dim01, double dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }
        //public double Dim01 { get; set; }
        //public double Dim02 { get; set; }

        public override double Perimeter { get { return (Dim01 + Dim02) * 2; } }
        //public override double CalcArea()
        //{
        //    return Dim01 * Dim02;
        //}
    }

    class Circle : Shape
    {
        public Circle(double reduis)
        {
            Dim01 = Dim02 = reduis;
        }
        //public double Dim01 { get; set; }

        public override double Perimeter { get { return 2 * Dim01 * 3.14; } }

        public override double CalcArea()
        {
            return 3.14 * Dim01 * Dim01;
            //return Math.PI * Dim01 * Dim01;
            //return Math.PI * Math.Pow(Dim01, 2);
        }
    }

    //class test02 : TestAccessModifers
    //{
    //    public test02()
    //    {
    //        //test = 1; // private => allow in current class only
    //        //test1 = 20; // private protected => allow in current class and derived class in same assembly
    //        test2 = 10; // protected => allow in current class and derived class
    //        test3 = 30; // internal protected => allow in current class and derived
    //        //test4 = 50; // internal =>allow in current class and derived
    //        test5 = 60; // public =>allow in current class and derived

    //    }
    //}
    //class test03 : test02
    //{
    //    public test03()
    //    {
    //        //test = 1; // private => allow in current class only
    //        //test1 = 20; // private protected => allow in current class and derived class in same assembly
    //        test2 = 10; // protected => allow in current class and derived class
    //        test3 = 30; // internal protected => allow in current class and derived
    //        //test4 = 50; // internal =>allow in current class and derived
    //        test5 = 60; // public =>allow in current class and derived
    //    }
    //}
}
