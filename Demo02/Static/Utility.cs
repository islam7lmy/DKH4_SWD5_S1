using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static
{
    /// Static Class
    /// is a just Container For Static Members [Attribute, Property, Constructor, Method] 
    /// and Constants
    /// You Can't Create Object From This Class (Helper Class)
    /// No Inheritance for this Class
    internal static class Utility
    {
        //public void test() { } //not valid

        /// Static Constructor [Maximum Only One Static Constructor Per Class]
        /// Can't Specifiy Access Modifiers or Parameters for Static Constructor
        /// Will be Executed Just Only One Time Per Class Lifetime Before the firts Usage of Class
        /// Usages Of Class
        /// 1. Call Static Mehtod or Static Property
        /// 2. set value for static property or filed
        static Utility()
        {
            //Hello();
            pi = 3.14;
        }
        private static double pi; //static filed
        public static double PI { get { return pi; } } //static property
        public static double CalcCircleArea(double Radius) //static method
        {
            //return 3.14 * Radius * Radius;
            return PI * Radius * Radius;
        }
        public static void Hello()
        {
            Console.WriteLine("hello");
        }
    }

    class test
    {
        /// Usages Of Class
        /// Create Object From This Class
        /// Create Object From Another Class Inheriting From This Class
        static test()
        {
            
        }
    }
}
