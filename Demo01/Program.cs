namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Comments
            // line comments
            /*
             * block comments
             */
            #endregion

            #region Value Type
            //int X;
            ///// allocate 4 uninitialized bytes in stack for X
            ///// int : c# keyword for integer data type
            //X = 5; // assign 5 to X

            //Int32 Y;
            ///// allocate 4 uninitialized bytes in stack for Y
            ///// int32 : .net type for integer data type
            //Y = 9; // assign 9 to Y

            //Y = X; // assign value of X to Y

            //X += 1;

            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            #endregion

            #region Reference Type
            //Point p1;
            ///// declare for reference from type point , referring to null
            ///// allocate 4 bytes in stack for p1 reference
            ///// zero bytes have been allocated in heap for Point instance

            ////Console.WriteLine(p1.GetHashCode()); //not valid as p1 is null reference and does not refer to any Point instance in heap

            //p1 = new Point();
            /////new
            /////1.allocate required bytes in heap for Point instance in heap [4 byte for x,4 byte y]
            /////2.initialize the allocated bytes with default values [0 for x, 0 for y]
            /////3.call user defined constructor for Point instance
            /////4.assign the address of allocated Point instance in heap to p1 reference in stack

            //Console.WriteLine(p1.GetHashCode());

            //Point p2 = new Point();

            //Console.WriteLine(p2.GetHashCode());

            //p2 = p1;
            ///// assign address of p1 to p2
            ///// p1 and p2 are now referring to the same Point instance in heap

            //Console.WriteLine("after assignment");
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());

            //p1.x = 10;

            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.y);
            #endregion

            #region object
            //object o1 = new Point();
            //object o2 = new Point();

            //o1.ToString(); // System.Object's ToString() method is called for o1
            //o1.GetHashCode(); // System.Object's GetHashCode() method is called for o1
            //o1.Equals(o2); // System.Object's Equals() method is called for o1 with o2 as argument
            //o1.GetType(); // System.Object's GetType() method is called for o1

            //int x = 10;

            //x.ToString(); // System.Int32's ToString() method is called for x
            //x.GetHashCode();
            //x.Equals(10);
            //x.GetType();

            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            //o2 = o1;
            //Console.WriteLine("After assignment");

            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            #endregion

            #region Fractions and discards
            //discards for readin only
            //Int64 x = 1_000_000_000_000_000_000;
            //int y = 1_000_000_000;
            //y = 1_739_825_647;

            //float f1 = 2.2f;
            //double d1 = 2.2;
            //decimal m1 = 2.2;

            //var x = 2.2m; // syntax sugar for double x = 2.2;
            #endregion

            #region VAlue type casting
            ///1. implicit casting (safe casting)
            int X = 5;
            long Y = X; // implicit casting from int to long
            Y = 777_373_896_547; // assign a long literal to Y

            ///2. explicit casting (unsafe casting)
            //X = (int)Y; // explicit casting from long to int, may cause data loss if Y is greater than int.MaxValue
            //Console.WriteLine(X);

            /// 3. checked and unchecked context for explicit casting
            //unchecked
            //{
            //    X = (int)Y; // explicit casting from long to int, may cause data loss if Y is greater than int.MaxValue
            //    Console.WriteLine(X);
            //}
            //checked
            //{
            //    X = (int)Y; // explicit casting from long to int, may cause data loss if Y is greater than int.MaxValue
            //    unchecked
            //    {
            //        Console.WriteLine(X);
            //    }
            //}
            #endregion
        }
    }
}
