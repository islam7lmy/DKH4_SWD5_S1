using Commen;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            /// Access Modifiers Types
            /// 1. private
            /// 2. private protected
            /// 3. protected
            /// 4. internal
            /// 5. internal protected
            /// 6. public

            //TypeA O1 = new TypeA();
            //O1.z = 10;

            //TypeC typeC = new TypeC();
            //typeC.z = 10;
            #endregion

            #region Struct
            #region ex01: Point 
            //Point p1;
            /////allocat 8 unitialized bytes in stack
            //Console.WriteLine(p1); //not valid

            //p1.X = 10;
            //p1.Y = 20;
            //Console.WriteLine(p1);

            //p1 = new Point();
            ///// new keyword just for Constructor selection that will initialize the attributes of struct 

            ////p1 = new Point(10,20);
            //p1 = new Point();

            //p1.X = 10;
            //p1.Y = 20;

            //Console.WriteLine(p1);
            #endregion
            #region ex02: Employee
            //Employee emp = new Employee(10,"ahmed mohmed ali ibrahem",4000,50);
            //Console.WriteLine(emp);

            ////emp.Name = "ahmed mohmed ali ibrahem";
            ////Console.WriteLine(emp.Name);

            //emp.SetName("ahmed mohmed ali ibrahem");
            //Console.WriteLine(emp.GetName());

            //emp.Salary = 1000;
            //Console.WriteLine(emp.Salary);

            //Console.WriteLine(emp.Deduction);
            #endregion
            #region ex03: [indexer] phonebook
            //(name , phone number)
            PhoneBook book = new PhoneBook(3);
            book.AddNumber("ahmed", 123);
            book.AddNumber("amr", 456);
            book.AddNumber("ali", 789);
            book.AddNumber("omr", 188);

            book.SetNumber("amr", 999);
            Console.WriteLine(book.GetNumber("amr"));

            book["ali"] = 999; //set of special prop [indexer]
            Console.WriteLine(book["ali"]); //get of special prop [indexer]

            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}

            //Console.WriteLine(book[5]);
            //Console.WriteLine(book);


            //book.Size = 20;
            for (int i = 0; i < book.Size; i++)
            {
                Console.WriteLine(book[i]);
            }

            //book.Size = 3;
            for (int i = 0; i < book.Size; i++)
            {
                Console.WriteLine(book[i]);
            }

            //book.Size = 2;
            for (int i = 0; i < book.Size; i++)
            {
                Console.WriteLine(book[i]);
            }
            #endregion
            #endregion
        }
    }
}
