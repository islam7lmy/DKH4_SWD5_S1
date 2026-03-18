using Commen;
using OOP.Inhertiance;
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
            //PhoneBook book = new PhoneBook(3);
            //book.AddNumber("ahmed", 123);
            //book.AddNumber("amr", 456);
            //book.AddNumber("ali", 789);
            //book.AddNumber("omr", 188);

            //book.SetNumber("amr", 999);
            //Console.WriteLine(book.GetNumber("amr"));

            //book["ali"] = 999; //set of special prop [indexer]
            //Console.WriteLine(book["ali"]); //get of special prop [indexer]

            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}

            //Console.WriteLine(book[5]);
            //Console.WriteLine(book);


            //book.Size = 20;
            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}

            ////book.Size = 3;
            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}

            ////book.Size = 2;
            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}

            //book.RemoveNumber("omr");
            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}
            #endregion
            #endregion

            #region Class
            #region ex:Car
            //Car c1;
            //// declare reference => refer to null => and then will refer on object of type car
            //// allocate 4 bytes in stack uninitilized => address
            //// zero bytes has been allocated in heap

            //c1 = new Car();
            ////new 
            //// 1. Allocate Required Number Of Bytes in HEAP
            //// 2. Initialize All Allocated Bytes With Default Value based on Its Datatype
            //// 3. Call User-Defined Constructor If Exists
            //// 4. Assign The Reference (C1) To Allocated Object

            //c1.Id = 10; //not valid because c1 not yet initilized
            //c1.Model = "BMW";//not valid because c1 not yet initilized
            //c1.Speed = 10;//not valid because c1 not yet initilized

            //Point p1;
            //p1.X = 10; // not valid becasue they are property
            //p1.Y = 10; // not valid becasue they are property

            //p1= new Point();
            //p1 = new Point(10, 20);

            //Car c1 = new Car();
            //Car c2 = new Car(30, "audi");
            //Car car = new Car(40, "skoda", 160);
            #endregion
            #region ex:Inhertance
            //object obj = new object();
            //obj.ToString();
            //obj.GetHashCode();
            //obj.GetType();
            //obj.Equals(obj);

            //Parent p1 = new Parent();
            //Child c1 = new Child();
            #endregion
            #region Realtionship between classes
            /// inhertance child is parent, dog is an animal
            /// aggregation has a 
            /// 1. composition => room has walls
            /// 2. association => room has chairs
            #endregion
            #region Class vs struct
            //Car c1 = new Car();
            //Car c2 = c1;
            //c2.Id = 10;
            //Console.WriteLine(c1.Id); //10
            /////Used for complex objects and behavior
            /////Reference type => stored reference in stack and object in heap
            /////Supports inheritance => [all access modifers]
            /////clr will always generate empty parameterless constructor ,if no user-defined constructor exists
            /////clr will no longer generate empty parameterless constructor, if u write user-defined constructor


            //Point p1 = new Point();
            //Point p2 = p1;
            //p2.X = 10;
            //Console.WriteLine(p1.X); // 0 
            /////Often used for small, simple data
            /////Value type => Stored on the stack
            /////Cannot inherit from another class =>  [private, internal, public]
            /////clr will always Generate Parameterless Constructor

            #endregion
            #endregion
        }
    }

    
}
