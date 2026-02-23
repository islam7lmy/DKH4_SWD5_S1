using System.Text;

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
            //decimal m1 = 2.2m;

            //var x = 2.2m; // syntax sugar for double x = 2.2;
            #endregion

            #region VAlue type casting
            ///1. implicit casting (safe casting)
            //int X = 5;
            //long Y = X; // implicit casting from int to long
            //Y = 777_373_896_547; // assign a long literal to Y

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

            ///4. parse (string to value type)
            //Console.WriteLine("please enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter your age");
            //int age =int.Parse(Console.ReadLine());
            //Console.WriteLine("hello " + name + " your age is " + age);

            ///5.tryparse (string to value type with error handling)
            //Console.WriteLine("please enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter your age");
            //int age;     // = int.Parse(Console.ReadLine());
            //bool result = int.TryParse(Console.ReadLine(), out age);
            //if(result)
            //{
            //    Console.WriteLine("hello " + name + " your age is " + age);
            //}
            //else
            //{
            //    Console.WriteLine("invalid input for age");
            //}

            ///6. convert class (convert from any datatype to any datatype)
            //Console.WriteLine("please enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("hello " + name + " your age is " + age);
            #endregion

            #region Operators
            #region Unary operators
            //int x = 10;
            ///// prefix [increment and then print]
            //Console.WriteLine(++x);// increment x to 11 and then print 11
            ///// postfix [print and then increment]
            //Console.WriteLine(x++);// print 11 and then increment x to 12
            //Console.WriteLine(x); // print 12
            ///// prefix [decrement and then print]
            //Console.WriteLine(--x); // decrement x to 11 and then print 11
            ///// postfix [print and then decrement]
            //Console.WriteLine(x--); // print 11 and then decrement x to 10
            //Console.WriteLine(x); // print 10

            //++x; //11
            //Console.WriteLine(x);
            //x++; //12
            //Console.WriteLine(x);
            //--x; //11
            //Console.WriteLine(x);
            //x--; //10
            //Console.WriteLine(x);
            #endregion

            #region Binary operators
            //int sum,mul,sub,div,mod;
            //int num1 = 10, num2 = 3;
            //sum = num1 + num2; // addition
            //mul = num1 * num2; // multiplication
            //sub = num1 - num2; // subtraction
            //div = num1 / num2; // division
            //mod = num1 % num2; // modulus

            //double div2 = 10.0 / 3; // 3.3333333333333335
            //double div2 =(double)num1 / num2; // int / int = int
            //Console.WriteLine(div2);
            #endregion

            #region Assignment operator
            //int x;
            //x = 10; // assignment operator
            ////10 = 5; // not valid as left hand side of assignment operator must be a variable
            //x += 5; // x = x + 5; // compound assignment operator
            //x -= 3; // x = x - 3; // compound assignment operator
            //x *= 2; // x = x * 2; // compound assignment operator
            //x /= 4; // x = x / 4; // compound assignment operator
            //x %= 3; // x = x % 3; // compound assignment operator
            #endregion

            #region Relational operator [comparision]
            //int x = 10, y = 20;
            //Console.WriteLine(x == y); // equality operator, returns true if x and y are equal, false otherwise
            //Console.WriteLine(x != y); // inequality operator, returns true if x and y are not equal, false otherwise
            //Console.WriteLine(x > y); // greater than operator, returns true if x is greater than y, false otherwise
            //Console.WriteLine(x < y); // less than operator, returns true if x is less than y, false otherwise
            //Console.WriteLine(x >= y); // greater than or equal to operator, returns true if x is greater than or equal to y, false otherwise
            //Console.WriteLine(x <= y); // less than or equal to operator, returns true if x is less than or equal to y, false otherwise
            #endregion

            #region logical operator
            //Console.WriteLine(!false); // logical NOT operator, returns true if the operand is false, false otherwise
            //Console.WriteLine(false && true); //short circute // logical AND operator, returns true if both operands are true, false otherwise
            //Console.WriteLine(true || false); //short circute // logical OR operator, returns true if at least one operand is true, false otherwise

            //Console.WriteLine((4<5) && (!(7<9) || 5 == 5));
            #endregion

            #region bitwise operator
            //Console.WriteLine(false & true); //long circute //bitwise AND operator, returns true if both operands are true, false otherwise
            //Console.WriteLine(true | false); //long circute //bitwise OR operator, returns true if at least one operand is true, false otherwise
            //Console.WriteLine(true ^ false); //bitwise XOR operator, returns true if exactly one operand is true, false otherwise
            #endregion

            #region Ternary operator [conditional operator]
            //int x = 4, y = 7, d = 15;

            //if (x > y)
            //    Console.WriteLine("x is greater than y");
            //else
            //    Console.WriteLine("y is greater than x");

            //Console.WriteLine(x > y ? "x is greater than y" : "y is greater than x");

            //int flag;
            //if (x > y)
            //    flag = 1;
            //else
            //    flag = 0;

            //int flag = x > y ? 1 : 0;

            ///not recommended as it is not readable
            //int max;
            //if (x > y)
            //    if (x > d)
            //        max = x;
            //    else
            //        max = d;
            //else
            //    if (y > d)
            //    max = y;
            //else
            //    max = d;

            //int max = x > y ? (x > d ? x : d) : (y > d ? y : d);
            #endregion

            #region Operator Priorty
            /*
             * 1. unary operators (prefix)
             * 2. round brackets  ()
             * 3. multiplicative operators (*, /, %)
             * 4. additive operators (+, -)
             */
            //int a = 20, b = 10, c = 15, d = 5, e;
            //e = (a + b) * c / d; // (20 + 10) *15/5 = 30 * 15 /5 = 450/5=90
            //e = ((--a + b) * c) / d; //((19 + 10) * 15)/5 = (29 * 15)/5 = 435/5=87
            //e = --a + b * c / d;//19 + 10 * 15 / 5 = 19 + 150 / 5 = 19 + 30 = 49
            #endregion
            #endregion

            #region string vs stringbuilder
            //string x = "Hello"; // syntex sugar for string x = new string("Hello"); // allocate memory in heap for string object with value "Hello" and assign its address to x reference in stack
            //Console.WriteLine(x.GetHashCode());
            ////string y = new string("Hello"); // allocate memory in heap for string object with value "Hello" and assign its address to y reference in stack
            //x += " World"; // creates a new string object in heap with value "Hello World" and assigns its address to x reference, the old string object with value "Hello" becomes eligible for garbage collection
            //Console.WriteLine(x.GetHashCode());
            ///////////////////////////////////////////////////
            //StringBuilder sb = new StringBuilder("Hello"); // allocate memory in heap for stringbuilder object with value "Hello" and assign its address to sb reference in stack
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append(" World"); // modifies the existing stringbuilder object in heap to have value "Hello World", sb reference still points to the same object, no new object is created
            //Console.WriteLine(sb.GetHashCode());
            //sb.Remove(5, 6);
            //sb.Replace("Hello", "C#");
            //sb.Insert(0, "Welcome to ");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region string Formating
            //Equation : 4 + 2 = 6
            //int x = 4, y = 2;
            //string result = "Equation : " + x + " + " + y + " = " + (x + y); // string concatenation
            //string result = string.Format("Equation : {0} + {1} = {2}",x,y,(x+y)); // string.Format method
            //string result = $"Equation : {x} + {y} = {x+y}"; // string interpolation
            #endregion
        }
    }
}
