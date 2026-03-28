using OOP.Inhertiance;
using OOP.PolyMorphism_OverRiding;
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

            #region PolyMorphism 
            #region Function overloading
            //Sum(10, 20, 30);
            #endregion
            #region Function OverRiding
            //TypeB b = new TypeB(10,20);
            //b.MyFun01(); //with new keyword
            //b.MyFun02(); //with override keyword
            #endregion
            #endregion

            #region Binding
            #region what is binding
            ///binding 
            ///1. reference from parent type => object from child type
            //TypeA A = new TypeB(10, 20);

            //TypeB B =(TypeB) new TypeA(10); //not binding

            //A.A = 10;
            //A.B = 20; //invalid

            /// 2.1 static binding [Early Binding]
            //// Compiler Will Bind Function Call Based On Reference Type NOT Object Type
            //// at Compilation Time
            ///A.MyFun01(); //will run parent code

            //// 2.2 Dynamic Binding [Late Binding]
            //// CLR Will Bind Function Call Based On Object Type NOT Reference Type
            //// at Runtime.
            //A.MyFun02();
            #endregion
            #region Not Binding
            //animal = dog; //binding
            //dog = (dog)animal; //not binding

            //Child c1 = (child)new Parent(); //not binding
            #endregion
            #region Why Need Binding
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //ProcessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //ProcessEmployee(partTimeEmployee);
            #endregion
            #region More Practise On Binding
            //TypeA typeA = new TypeC(1,2,3); //// Reference From InDirect Parent
            //typeA.A = 11;
            ////typeA.B = 22;//invalid
            ////typeA.C = 33;//invalid
            //typeA.MyFun01(); // static bincded method => I am Base [Parent]
            //typeA.MyFun02(); // Dynamic Binded Method => TypeC: A = 11, B = 2 , C = 3

            //TypeB typeB = new TypeC(1, 2, 3);// Reference From Direct Parent
            //typeB.A = 11;
            //typeB.B = 12;
            ////typeB.C = 33; invalid
            //typeB.MyFun01(); //static bincded method => I am Base [Child]
            //typeB.MyFun02(); // Dynamic Binded Method => TypeC: A = 11, B = 12 , C = 3

            //TypeA typeA = new TypeD(1, 2, 3, 4); 
            //TypeB typeB = new TypeD(1, 2, 3, 4); 
            //TypeC typeC = new TypeD(1, 2, 3, 4); 

            //typeA.MyFun02(); //TypeC: A = 1, B = 2, C = 3
            //typeB.MyFun02(); //TypeC: A = 1, B = 2, C = 3
            //typeC.MyFun02(); //TypeC: A = 1, B = 2, C = 3

            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD1 = new TypeD(1, 2, 3, 4);
            //TypeD typeD2 = new TypeE(1, 2, 3, 4, 5);


            //typeA.MyFun02();//TypeC: A = 1, B = 2, C = 3
            //typeB.MyFun02();//TypeC: A = 1, B = 2, C = 3
            //typeC.MyFun02();//TypeC: A = 1, B = 2, C = 3
            //typeD1.MyFun02();//TypeD: A = 1, B = 2 , C = 3, D = 4
            //typeD2.MyFun02();//TypeE: A = 1, B = 2, C = 3, D = 4, E = 5 

            #endregion
            #endregion
        }

        #region PolyMorphism 1. Function overloading
        //1.data type of paramaters
        //2.count of paramaters
        //3.order if not same data type of paramaters
        public static int Sum(int x , int y)
        {
            return x + y;
        }
        //public static double Sum(int x, int y)  //not overloading
        //{
        //    return x + y;
        //}
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static int Sum(double x, int y)
        {
            return (int)(x + y);
        }
        public static int Sum(int x, double y)
        {
            return (int)(x + y);
        }
        #endregion

        #region Why Need Binding
        //public static void ProcessEmployee(Employee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01(); // static binded method => i am employee
        //        emp.MyFun02(); // dynamic Binded Method
        //    }
        //}
        ////public static void ProcessEmployee(FullTimeEmployee emp)
        ////{
        ////    if(emp is not null)
        ////    {
        ////        emp.MyFun01();
        ////        emp.MyFun02();
        ////    }
        ////}
        ////public static void ProcessEmployee(PartTimeEmployee emp)
        ////{
        ////    if (emp is not null)
        ////    {
        ////        emp.MyFun01();
        ////        emp.MyFun02();
        ////    }
        ////}
        ////public static void ProcessEmployee(FreelanceEmployee emp)
        ////{
        ////    if (emp is not null)
        ////    {
        ////        emp.MyFun01();
        ////        emp.MyFun02();
        ////    }
        ////}
        #endregion
    }
}
