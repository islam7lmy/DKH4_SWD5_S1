using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    // Interface: is a contract that defines a set of
    // methods, properties, events, or indexers that a class or struct must implement.
    internal interface IMyType
    {
        /// What You Can Write Inside The Interface?
        /// 1. Method Signature
        /// 2. Property Signature
        /// 3. Event Signature
        /// 4. Indexer Signature
        /// 5. Default Implementation (c# 8.0 +)

        /// Default Access Modifier Inside The Interface is Public
        /// Private Access Modifier Is Not Allowed Inside The Interface


        /// Property Signature
        int Salary { get; set; }

        /// Method Signature
        void MyFun();

        void Print()
        {
            Console.WriteLine("Hello I am Default Implementation");
        }
    }

    class MyTypev1 : IMyType /// => Implementing The Interface
    {
        public int Age { get; set; }

        /// Implementing The Property
        public int Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello");
        }

        //public void Print()
        //{
        //    Console.WriteLine("Hello I am Overriding The Default Implementation");
        //}
    }

    class MyTypev2 : IMyType
    {
        public int Salary { get; set; }
        public void MyFun()
        {
            Console.WriteLine("Hello");
        }
    }

    class MyTypev3
    {
        public int Salary { get; set; }
        public void MyFun()
        {
            Console.WriteLine("Hello");
        }
    }
}
