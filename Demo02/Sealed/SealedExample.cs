using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Hello Parent");
        }
    }

    class child02 : Parent
    {
        public override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value - 1500; }
        }
        public override void Print()
        {
            Console.WriteLine("hello child");
        }
    }

    class child : Parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value - 1500; }
        }
        public sealed override void Print()
        {
            Console.WriteLine("hello child");
        }
    }

    sealed class GrandChild : child
    {
        public GrandChild()
        {
            Salary = 10000;
            Print();
        }

        void test()
        {
            Salary = 10;
            Print();
        }

        ///static binded avilable
        public new void Print()
        {
            Console.WriteLine("hello child");
        }

        //public override int Salary
        //{ get => base.Salary; set => base.Salary = value; } //=> not valid

        //public override void print() //=> not valid
        //{
        //    base.print();
        //}
    }

    //class GrandGrandChild : GrandChild  //not valid


}
