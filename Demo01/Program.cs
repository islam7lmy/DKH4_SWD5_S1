using System.Collections;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Conditional Statment
            #region Ex01
            #region if
            //Console.WriteLine("insert number of month in first qurter of year:");
            //int month;
            //if (int.TryParse(Console.ReadLine(), out month))
            //{
            //    //not recommended as it is not readable
            //    //Console.WriteLine(
            //    //month == 1 ? "January" :(month == 2 ? "February" :(month == 3 ? "March" : "invalid month number")));

            //    //if (month == 1)
            //    //    Console.WriteLine("January");
            //    //else if (month == 2)
            //    //    Console.WriteLine("February");
            //    //else if (month == 3)
            //    //    Console.WriteLine("March");
            //    //else
            //    //    Console.WriteLine("invalid input for month");
            //}
            //else
            //{
            //    Console.WriteLine("invalid input for month");
            //}
            #endregion
            #region switch
            //Console.WriteLine("insert number of month in first qurter of year:");
            //int month;
            //if (int.TryParse(Console.ReadLine(), out month))
            //{
            //    /// jump table is created for switch statement with cases 1, 2, 3 and default case
            //    switch (month)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;
            //        case 2:
            //            Console.WriteLine("February");
            //            break;
            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        default:
            //            Console.WriteLine("invalid input for month");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invalid input for month");
            //}
            #endregion
            #endregion
            #region Ex02
            //int salary;
            //if (int.TryParse(Console.ReadLine(), out salary))
            //{
            //    //switch (salary)
            //    //{
            //    //    case 3000:
            //    //        Console.WriteLine("option 03");
            //    //        Console.WriteLine("option 02");
            //    //        Console.WriteLine("option 01");
            //    //        break;
            //    //    case 2000:
            //    //        Console.WriteLine("option 02");
            //    //        Console.WriteLine("option 01");
            //    //        break;
            //    //    case 1000:
            //    //        Console.WriteLine("option 01");
            //    //        break;
            //    //    default:
            //    //        Console.WriteLine("can not do any option");
            //    //        break;
            //    //}

            //    switch (salary)
            //    {
            //        case 3000:
            //            Console.WriteLine("option 03");
            //            //Console.WriteLine("option 02");
            //            //Console.WriteLine("option 01");
            //            //break;
            //            goto case 2000; // jump to case 2000
            //        case 2000:
            //            Console.WriteLine("option 02");
            //            //Console.WriteLine("option 01");
            //            //break;
            //            goto case 1000; // jump to case 1000
            //        case 1000:
            //            Console.WriteLine("option 01");
            //            break;
            //        default:
            //            Console.WriteLine("can not do any option");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}
            #endregion
            #region Calculater
            // take number then opration then number and show result
            //calculator do (+ - * / %)
            //write program to do that and make it protictive
            //int num1, num2;
            //char opr;
            //Console.WriteLine("Enter first number:");
            //if (!int.TryParse(Console.ReadLine(), out num1)) //! true = false || ! false = true
            //    Console.WriteLine("invalid format for first number");

            //Console.WriteLine("Enter opration (+ - * / %):");
            //if (!(char.TryParse(Console.ReadLine(), out opr) && (opr == '+' || opr == '-' || opr == '*' || opr == '/' || opr == '%')))
            //    Console.WriteLine("invalid format for opration");

            //Console.WriteLine("Enter last number:");
            //if (!int.TryParse(Console.ReadLine(), out num2)) //! true = false || ! false = true
            //    Console.WriteLine("invalid format for last number");

            /////jump table is created for switch statement with cases +, -, *, /, % and default case
            //switch (opr)
            //{
            //    case '+':
            //        Console.WriteLine("result: " + (num1 + num2));
            //        break;
            //    case '-':
            //        Console.WriteLine("result: " + (num1 - num2));
            //        break;
            //    case '*':
            //        Console.WriteLine("result: " + (num1 * num2));
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //            Console.WriteLine("result: " + ((double)num1 / num2));
            //        else
            //            Console.WriteLine("can not divide by zero");
            //        break;
            //    case '%':
            //        if (num2 != 0)
            //            Console.WriteLine("result: " + (num1 % num2));
            //        else
            //            Console.WriteLine("can not divide by zero");
            //        break;
            //        //default: //there is no need for default case as we have already validated the opration input but it is added here for completeness
            //        //    Console.WriteLine("invalid opration");
            //        //    break;
            //}
            #endregion
            #endregion

            #region Loops Statment
            // print numbers from 1 to 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            #region For
            /// for(insilization; condtion; increment | decrement)
            ///  body
            ///  
            /// 1. insilization
            /// 2. check condtion
            /// 3. if condition true => do body code
            /// 4. increment | decrement
            /// 5. check condtion
            /// 6. if condition true => do body code
            /// 7. increment | decrement

            //for(int i = 1; i <= 10; i++) // ++i; //i += 1 //i = i + 1
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1; // insilization
            //for (; ; )
            //{
            //    if (i <= 10) // condition
            //    {
            //        if (i % 2 == 0)
            //        {
            //            i++; // increment
            //            continue; // skip the rest of the loop body and go to the next iteration
            //        }
            //        Console.WriteLine(i); // body
            //        i++; // increment
            //    }
            //    else
            //        break; // exit the loop
            //}

            #endregion

            #region while
            //Console.WriteLine("insert 0 if you want to Continue");
            //string input = Console.ReadLine();
            //while (input == "0")
            //{
            //    Console.WriteLine("hello");
            //    Console.WriteLine("insert 0 if you want to continue or any key if you want to exit");
            //    input = Console.ReadLine();
            //}

            ///while(reader.read())
            ///{
            ///   do some code to read data from reader
            /// }

            //int num1, num2;
            //char opr;
            //while (true)
            //{
            //    Console.WriteLine("Enter first number:");
            //    while (!int.TryParse(Console.ReadLine(), out num1)) //! true = false || ! false = true
            //        Console.WriteLine("wrong foramt, Enter first number");

            //    Console.WriteLine("Enter opration (+ - * / %):");
            //    while (!(char.TryParse(Console.ReadLine(), out opr) && (opr == '+' || opr == '-' || opr == '*' || opr == '/' || opr == '%')))
            //        Console.WriteLine("wrong foramt, Enter opration (+ - * / %):");

            //    Console.WriteLine("Enter last number:");
            //    while (!int.TryParse(Console.ReadLine(), out num2)) //! true = false || ! false = true
            //        Console.WriteLine("wrong foramt, Enter last number");

            //    var result = 0;
            //    Console.WriteLine($"Eqution: {num1} {opr} {num2} = {result}");
            //    Console.WriteLine("////////////////////////////////////////////////////////");
            //}
            #endregion

            #region do while
            //for (int i = 11; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 11;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}while (i <= 10);
            #endregion

            #region foreach
            //string text = Console.ReadLine();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.WriteLine(text[i]);
            //}

            ///// collections
            //foreach (char item in text)
            //    Console.WriteLine(item);

            //List<string> names = new List<string>()
            //{
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};

            //for (int i = 0; i < names.Count; i++) //with collection to edit
            //{
            //    names[i] += "hello";
            //}

            //vs

            //foreach (string name in names)
            //    name += "hello"; //not valid //for display
            #endregion

            #region EX00
            #region phas 01
            //int num1, num2;
            //char opr;
            //double result;
            //Console.WriteLine("Enter first number:");
            //if (!int.TryParse(Console.ReadLine(), out num1)) //! true = false || ! false = true
            //{
            //    Console.WriteLine("invalid format for first number");
            //    return;
            //}
            //Console.WriteLine("Enter opration (+ - * / %):");
            //if (!(char.TryParse(Console.ReadLine(), out opr) && (opr == '+' || opr == '-' || opr == '*' || opr == '/' || opr == '%')))
            //{
            //    Console.WriteLine("invalid format for opration");
            //    return;
            //}
            //Console.WriteLine("Enter last number:");
            //if (!int.TryParse(Console.ReadLine(), out num2)) //! true = false || ! false = true
            //{
            //    Console.WriteLine("invalid format for last number");
            //    return;
            //}
            //else if ((opr == '/' || opr == '%') && num2 == 0)
            //{
            //    Console.WriteLine("can not divide by zero");
            //    return;
            //}
            /////jump table is created for switch statement with cases +, -, *, /, % and default case
            //switch (opr)
            //{
            //    case '+': result = num1 + num2; break;
            //    case '-': result = num1 - num2; break;
            //    case '*': result = num1 * num2; break;
            //    case '/': result = (double)num1 / num2; break;
            //    case '%': result = num1 % num2; break;
            //    default: return;
            //}
            //Console.WriteLine($"{num1} {opr} {num2} = {result}");
            #endregion

            #region phas 02
            //int num1, num2;
            //char opr;
            //double result;
            //do
            //{
            //    Console.WriteLine("Enter first number:");
            //    while (!int.TryParse(Console.ReadLine(), out num1))
            //    {
            //        Console.WriteLine("wrong format, Enter first number:");
            //    }

            //    Console.WriteLine("Enter opration (+ - * / %):");
            //    while (!(char.TryParse(Console.ReadLine(), out opr) && (opr == '+' || opr == '-' || opr == '*' || opr == '/' || opr == '%')))
            //    {
            //        Console.WriteLine("wrong format, Enter opration (+ - * / %):");
            //    }

            //    Console.WriteLine("Enter last number:");
            //    while (!int.TryParse(Console.ReadLine(), out num2) || ((opr == '/' || opr == '%') && num2 == 0))
            //    {
            //        Console.WriteLine($"wrong format, Enter last number {(opr == '/' || opr == '%' ? "and make sure not be zero" : "")}:");
            //    }
            //    ///jump table is created for switch statement with cases +, -, *, /, % and default case
            //    switch (opr)
            //    {
            //        case '+': result = num1 + num2; break;
            //        case '-': result = num1 - num2; break;
            //        case '*': result = num1 * num2; break;
            //        case '/': result = (double)num1 / num2; break;
            //        case '%': result = num1 % num2; break;
            //        default: return;
            //    }
            //    Console.WriteLine($"{num1} {opr} {num2} = {result}");
            //    Console.WriteLine("******************************************************");
            //    Console.WriteLine("if you want to do anthor operation enter 'y' or press any key to exit");
            //} while ((Console.ReadLine()).ToLower() == "y");
            #endregion
            #endregion
            #endregion

            #region Block scope
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(i); // out of scope

            //while (!double.TryParse(Console.ReadLine(), out double x))
            //{
            //    Console.WriteLine(x);
            //}
            //x = 3; // out of scope

            ////double y;
            //if (!double.TryParse(Console.ReadLine(), out double y))
            //{
            //    int z = 0;
            //    Console.WriteLine(y);
            //}
            //y = 3;
            //z = 3; // out of scope
            //int x= 0;
            //{ int z = 0; x = 1; }
            //{ int z = 0; x = 2; }
            #endregion

            #region Arrays
            #region one D Array
            //int[] numbers;
            // Declare for Reference from Type "Array of Integrs"
            // Refering to the default value of Reference Type = NULL
            // CLR Will Allocate 4 Bytes for The Reference at STACK
            // CLR Will Allocate Zero Bytes at HEAP  

            //numbers = new int[5];
            // CLR Allocate 20 Bytes at HEAP,
            // Intiailized with the default value of int = 0
            // make reference refer on first element in object of array

            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };

            //numbers[0] = 1;
            //numbers[4] = 2; // size - 1
            //numbers[5] = 3; // not valid // runtime error

            //Console.WriteLine($"the size of array = {numbers.Length} , the number of dimensions = {numbers.Rank} ");
            //Console.WriteLine($"the size of array = {numbers.GetLength(0)} {numbers.GetLength(1)} , the number of dimensions = {numbers.Rank} "); // run time error

            //write a program with protictive code to read elemnts of array from user
            //then print all elements
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"enter the {i + 1} element of array");
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine($"wrong format, please enter the {i + 1} element of array");
            //    }
            //}

            //int x = 1;
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine($"the {x} element of array : {i}");
            //    x++;
            //}
            #endregion
            #region Two D Array [Rectangular]
            //int[,] Marks;
            //Marks = new int[3, 5];  //[rows , column]

            //Console.WriteLine($"the size of array = {Marks.Length} , the number of dimensions = {Marks.Rank} ");
            //Console.WriteLine($"row number {Marks.GetLength(0)}, column number {Marks.GetLength(1)} ");

            //Marks[1, 2] = 11;

            /////read elments of arry from user 
            /////print elemnts of arry to user
            /////write program to do that with protictive code and readable messages
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter array element Marks[{i},{j}]");
            //        while (!int.TryParse(Console.ReadLine(), out Marks[i, j]))
            //        {
            //            Console.WriteLine($"wrong format, enter array element Marks[{i},{j}]");
            //        }
            //    }

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    int r = i / Marks.GetLength(1); //element / column count
            //    int c = i % Marks.GetLength(1); //element / column count

            //    Console.WriteLine($"enter array element Marks[{r},{c}]");
            //    while (!int.TryParse(Console.ReadLine(), out Marks[r, c]))
            //    {
            //        Console.WriteLine($"wrong format, enter array element Marks[{r},{c}]");
            //    }
            //}

            //foreach (int item in Marks)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region [Jagged Array]
            //int[,][,] arr;
            //arr = new int[3, 5][,];

            //arr[0, 0] = new int[2, 4]; //st0
            //arr[0, 1] = new int[1, 3]; //st1
            //arr[0, 2] = new int[2, 1]; //st2


            //Console.WriteLine($"the size of array = {arr.Length} , the number of dimensions = {arr.Rank} ");
            //Console.WriteLine($"row number {arr.GetLength(0)}, column number {arr.GetLength(1)} ");
            //Console.WriteLine($"the size of st0 = {arr[0, 0].Length} , the number of dimensions = {arr[0, 0].Rank} ");
            //Console.WriteLine($"row number {arr[0, 0].GetLength(0)}, column number {arr[0, 0].GetLength(1)}");

            /////read elments of arry from user 
            /////print elemnts of arry to user
            /////write program to do that with protictive code and readable messages
            //int[,][,] arr;
            //arr = new int[2, 2][,];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int r = i / arr.GetLength(1); //element / column count
            //    int c = i % arr.GetLength(1); //element / column count
            //    int dim1, dim2;

            //    Console.WriteLine($"enter array element arr[{r},{c}] deminssion 1");
            //    while (!int.TryParse(Console.ReadLine(), out dim1))
            //    {
            //        Console.WriteLine($"wrong format, enter array element arr[{r},{c}] deminssion 1");
            //    }

            //    Console.WriteLine($"enter array element arr[{r},{c}] deminssion 2");
            //    while (!int.TryParse(Console.ReadLine(), out dim2))
            //    {
            //        Console.WriteLine($"wrong format, enter array element arr[{r},{c}] deminssion 2");
            //    }

            //    arr[r, c] = new int[dim1, dim2];

            //    for (int inneri = 0; inneri < arr[r, c].Length; inneri++)
            //    {
            //        int innerr = inneri / arr[r, c].GetLength(1); //element / column count
            //        int innerc = inneri % arr[r, c].GetLength(1); //element / column count

            //        Console.WriteLine($"enter array element arr[{r},{c}][{innerr},{innerc}]");
            //        while (!int.TryParse(Console.ReadLine(), out arr[r, c][innerr, innerc]))
            //        {
            //            Console.WriteLine($"wrong format, enter array element Marks[{r},{c}][{innerr},{innerc}]");
            //        }
            //    }
            //}

            //foreach (var innerarr in arr)
            //    foreach (var item in innerarr)
            //        Console.WriteLine(item);
            #endregion
            #region Array Methods
            //double[] numbers = { 8, 3, 4, 5, 6, 7, 9, 7, 1, 3 };
            #region 1. Class Member Methods [Static Methods]
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers);
            //Console.WriteLine(Array.IndexOf(numbers,3));  //first index
            //Console.WriteLine(Array.LastIndexOf(numbers,3));  //last index
            //var arr = Array.CreateInstance(typeof(int), 10); //int[] newarr = new int[10];
            #endregion
            #region 2. Object Member Methods [Non-Static Methods]
            //int[] newarr = new int[15];
            //Console.WriteLine(newarr.GetType());
            //numbers.CopyTo(newarr, 2);
            //numbers.SetValue(18, 5);
            //Console.WriteLine(numbers[5]);

            //var destination = Array.CreateInstance(numbers.GetType().GetElementType(), numbers.Length);
            //numbers.CopyTo(destination, 0);
            //foreach (var i in destination)
            //    Console.WriteLine(i);
            #endregion

            //foreach (var item in newarr)
            //{
            //    Console.WriteLine(item);
            //}



            ///Ex01: write a program find the longest distance between Two equal cells.
            ///In this example.The distance is measured by the number Of cells- for example
            //int size;
            //Console.WriteLine("enter size of array");
            //while(!int.TryParse(Console.ReadLine(),out size) || size < 1)
            //    Console.WriteLine("wrong format, enter size of array");
            //int[] arr = new int[size];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter the {i + 1} element of array");
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        Console.WriteLine($"wrong format, please enter the {i + 1} element of array");
            //    }
            //}
            //int[] temp = new int[size];
            //for (int i = 0;i < temp.Length;i++)
            //{
            //    temp[i] = Array.LastIndexOf(arr, arr[i]) - Array.IndexOf(arr, arr[i]);
            //}
            //Array.Sort(temp);
            ////Console.WriteLine(temp[temp.Length-1]);
            //Array.Reverse(temp);
            //Console.WriteLine(temp[0]);
            #endregion
            #endregion

            #region Boxing vs UnBoxing [not recomended]
            //// Boxing   : Casting from ValueType to ReferenceType
            //// UnBoxing : Casting from ReferenceType to ValueType

            //int is object
            //int x = 10;
            //object obj = x; //boxing => copy of data saved in x
            //x = 20;
            //Console.WriteLine(obj);

            //object[] data = new object[3];
            //data[0] = 10; //boxing
            //data[1] = 3.5; //boxing
            //data[2] = "ali"; 

            ///unboxing
            //object obj = 10;
            //int x =(int) obj; //explicit casting
            //Console.WriteLine(x);
            //double x = (double) obj;
            //Console.WriteLine(x);

            //ArrayList list = new ArrayList();
            //list.Add("1");
            //list.Add(1);
            //list.Add(1.2);

            //List<int> ints = new List<int>();
            //ints.Add(10);


            //object O1 = new object();
            //O1 = "Ahmed";

            //O1 = 5;    // int[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 'A';  // char[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 3.3;  // double[ValueType] to object[ReferenceType] -> Boxing
            //O1 = true; // bool[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateTime();  // DateTime[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateOnly(); // DateOnly[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new TimeOnly(); // TimeOnly[ValueType] to object[ReferenceType] -> Boxing
            #endregion

            #region Nullable types
            // NullableTypes : ValueTypes allows NULL as a Value
            // Assign Null as a Value for ValueType[int, char, bool, decimal, etc] Variables

            //int age = 0;
            //age = null; //invalid

            //int? age = null; //nullable integer : allow int value + null
            //double? age2 = null; //nullable double : allow int value + null

            //Console.WriteLine(age + age2);

            //double x = 8; // allow int value only
            //double? y =(int) x; //safe casting // allow int value + null 
            //y = null;
            //y = 6.9;

            //if (y is not null)
            //    x = (int)y;

            //if (y.HasValue)
            //    x = y.Value;

            //Console.WriteLine(x);

            //x = y.HasValue ? y.Value : 0;

            /////null-coalescing operator
            //x = y ?? 0;

            #endregion

            #region Null Propagation Operator
            //double x = default; // 0
            //int[] arr = default; // null

            ////int length = arr.Length;
            ////int? length = arr?.Length;
            ////int length = arr?.Length ?? 0;
            //if (arr is not null)
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }

            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //employee?.department?.deptname;
            #endregion

            #region Functions
            #region prototype and calling
            //PrintLines();
            //PrintLines(20,"$");// Passing Parameters By Position
            ////PrintLines(,"$");//invalid
            //PrintLines(pattern: @"/**\");// Passing Parameters By Name
            //PrintLines(pattern: @"/**\", number: 15);// Passing Parameters By Name
            #endregion

            #region Value type
            //int num01 = 9, num02 = 4;
            //Console.WriteLine($"num01 = {num01} , num02 = {num02}");

            ////Swap(num01, num02); // passing by value

            //Swap(ref num01,ref num02); // passing by reference

            //Console.WriteLine($"num01 = {num01} , num02 = {num02}");
            #endregion

            #region reference type
            //int[] numarr = { 3, 5, 6 };
            ////Console.WriteLine(SumArray(numarr)); // passing by value
            //Console.WriteLine(SumArray(ref numarr)); // passing by reference
            //Console.WriteLine(numarr.GetHashCode());
            //Console.WriteLine(numarr[0]); 
            #endregion

            #region Passing by out
            //int a = 6, b = 3, sum , mul;
            //SumMul(a, b, out a, out b);
            //SumMul(a, b, out _, out b);
            //Console.WriteLine($"a = {a} , b = {b}");
            //SumMul(a, b, ref sum, ref mul);
            #endregion
            #region params
            //int[] newarr = new int[6] { 1, 2, 3, 4, 5, 6 };
            //SumArray(newarr);

            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11));
            #endregion
            #endregion

            #region Exceptions Handling
            //while (true)
            //{
            //    try
            //    {
            //        DoSomeCode();
            //    }
            //    catch (Exception ex)
            //    {
            //        //throw;
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        // [release | deallocate | Delete | close] unmanaged //resources [databaseconnection , file]
            //        Console.WriteLine("finally");
            //    }
            //    Console.WriteLine("the program is still runing");
            //}

            /* Exception
            ////// 1. SystemException
            //////////////// 1. FormatException
            //////////////// 2. IndexOutOfRangeException
            //////////////// 4. NullReferenceException
            //////////////// 4. InvalidOperationException
            //////////////// 5. ArithmeticException
            ///////////////////////// 5.1 DivideByZeroException
            ///////////////////////// 5.2 OverflowException
            ////// 2. ApplicationException
            */
            #endregion

            #region Enums
            //days day = days.sat;
            //Console.WriteLine(day.ToString());
            //Console.WriteLine((int) day);
            //string x = day.ToString();
            //int y =(int) day;

            //Point p1 = new Point();
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.ToString());

            //Console.WriteLine((int)days.sat);
            //Console.WriteLine((int)days.tus);
            //Console.WriteLine((int)days.wed);


            //Console.WriteLine((int)Gender.Male); //1
            //Console.WriteLine((int)Gender.male); //2
            //Console.WriteLine((int)Gender.M);    //3
            //Console.WriteLine((int)Gender.m);    //4
            //Console.WriteLine((int)Gender.Female);//2
            //Console.WriteLine((int)Gender.female);//3
            //Console.WriteLine((int)Gender.F);     //4
            //Console.WriteLine((int)Gender.f);     //5

            #region  Ex: enums + params
            CalculateBill(14,12,Menu.Pizza,Menu.Juice,Menu.Salad,Menu.Dessert);
            #endregion


            #endregion
        }

        #region functions
        #region prototype and calling
        //public static void PrintLines()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine("");
        //}

        //public static void PrintLines(int number, string pattern)
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine("");
        //}

        //public static void PrintLines(int number = 5, string pattern = "#")
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine("");
        //}
        #endregion
        #region value type
        ///value type ,pass by value
        //public static void Swap(int x, int y)
        //{
        //    //Console.WriteLine($"num01 = {x} , num02 = {y}");
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    //Console.WriteLine($"num01 = {x} , num02 = {y}");
        //}

        ///value type , paas by reference
        //public static void Swap(ref int x,ref int y)
        //{
        //    //Console.WriteLine($"num01 = {x} , num02 = {y}");
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    //Console.WriteLine($"num01 = {x} , num02 = {y}");
        //}
        #endregion
        #region reference type
        ///// reference type, passing by value
        //public static int SumArray(int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[] { 1, 2, 3 };
        //    foreach (int i in Arr)
        //    {
        //        sum += i;
        //    }
        //    Console.WriteLine(Arr.GetHashCode());
        //    return sum;
        //}

        ///// reference type, passing by reference
        //public static int SumArray(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[] { 1, 2, 3 };
        //    foreach (int i in Arr)
        //    {
        //        sum += i;
        //    }
        //    Console.WriteLine(Arr.GetHashCode());
        //    return sum;
        //}
        #endregion
        #region out
        /// By Value     => Read Only
        /// By Ref       => Read  at First and Then Write (Parameter Passed By Ref, Must be initialized Before Passed)
        /// By Out       => Write at First and Then Read (Parameter Passed By Out, Must be initialized Inside Function)
        //public static void SumMul(int x, int y, out int sum, out int mul)
        //{
        //    //sum = 0;
        //    //mul = 0;
        //    //sum = x + y;
        //    //mul = x * y;
        //}
        //public static void SumMul(int x, int y, ref int sum, ref int mul)
        //{
        //    //sum = x + y;
        //    //mul = x * y;
        //}
        #endregion
        #region params
        //public static int SumArray(int[] Arr)
        //{
        //    int sum = 0;

        //    foreach (int i in Arr)
        //    {
        //        sum += i;
        //    }

        //    return sum;
        //}

        //public static int SumArray(int tax, int service, params object[] Arr)
        //{
        //    int sum = 0;

        //    foreach (int i in Arr)
        //    {
        //        sum += i;
        //    }

        //    return sum;
        //}

        #region Ex: enums + params
        static double CalculateBill(int tax, int service, params Menu[] items)
        {
            double total = 0, taxinmony = 0, serviceinmony = 0;
            Console.WriteLine("Order Details:");

            foreach (Menu item in items)
            {
                Console.WriteLine($"{item.ToString()} : {(int)item}");
                total += (int)item;
            }

            Console.WriteLine("ـــــــــــــــــــــــــــ");
            Console.WriteLine($"Total Items : {total}");
            taxinmony = total * ((double)tax / 100);
            Console.WriteLine($"Tax : {taxinmony}");
            serviceinmony = total * ((double)service / 100);
            Console.WriteLine($"Service : {serviceinmony}");
            Console.WriteLine($"Total Order : {total + taxinmony + serviceinmony}");
            return total;
        }
        #endregion
        #endregion
        #endregion

        #region Exceptions Handling
        //static void DoSomeCode()
        //{
        //    int x, y, z;
        //    Console.WriteLine("please enter first number: ");
        //    x = int.Parse(Console.ReadLine());

        //    Console.WriteLine("please enter seconed number: ");
        //    y = int.Parse(Console.ReadLine());

        //    z = x / y;

        //    Console.WriteLine($"result is : {z}");

        //    int[] arr = new int[3] { 1, 2, 3 };

        //    Console.WriteLine("please enter the index to change it's value");

        //    int index = int.Parse(Console.ReadLine());

        //    arr[index] = 99;
        //}

        //static void DoSomeProtictiveCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        do
        //        {
        //            Console.WriteLine("please enter first number: ");
        //        } while (!int.TryParse(Console.ReadLine(), out x));

        //        do
        //        {
        //            Console.WriteLine("please enter seconed number: ");
        //        } while (!int.TryParse(Console.ReadLine(), out y) || y == 0);

        //        z = x / y;

        //        Console.WriteLine($"result is : {z}");

        //        int[] arr = new int[3] { 1, 2, 3 };

        //        int index;
        //        do
        //        {
        //            Console.WriteLine("please enter the index to change it's value");

        //        } while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= arr.Length);

        //        arr[index] = 99;
        //    }
        //    catch (Exception ex)
        //    { 
        //        Console.WriteLine(ex.Message); 
        //    }
        //}
        #endregion
    }

    /// 1. struct
    /// 2. enum
    /// 3. class
    /// 4. interface

    #region Enums
    //enum days
    //{
    //    sat,
    //    sun,
    //    mon,
    //    tus = 10,
    //    wed,
    //    thr,
    //    fri
    //}

    //enum Gender : int
    //{
    //    Male = 1, male , M , m , Female = 2, female , F , f 
    //}

    //enum branches : byte
    //{
    //    samrtvally = 105, gamsa = 201, _6oct = 252 , alex , mansoura, bns 
    //}

    #region Ex: enums + params
    enum Menu
    {
        Pizza = 120,
        Burger = 150,
        Juice = 40,
        Salad = 30,
        Dessert = 60
    }
    #endregion
    #region Premissions

    #endregion
    #endregion
}
