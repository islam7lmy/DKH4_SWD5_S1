using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    //interface ICompare
    //{
    //    //+ve : this > obj
    //    //-ve : this < obj
    //    //0 : this == obj
    //    int Compare(object obj);
    //}

    internal static class Helper//<T,T1,T2> where T : IComparable<T> where T2 : IComparable<T2> where T1 : IComparable<T1>
    {
        #region EX01 Swap
        #region Non-Genrics
        //public static void SWAP(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void SWAP(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void SWAP(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void SWAP(object x,object y)  //boxing && unboxing
        //{
        //    object temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #region Generics
        /// T => Template
        public static void SWAP<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        //public static void SWAP<T,T1>(ref T x, ref T1 y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #endregion

        #region EX02 Search
        #region Non-Generics
        //public static int SearchArray(int[] arr, int value)
        //{
        //    if(arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (value == arr[i])
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion
        #region Generics
        public static int SearchArray<T>(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value.Equals(arr[i]))
                        return i;
                }
            }
            return -1;
        }
        #endregion
        #endregion

        #region EX03 BubbleSort
        #region nonGenrics
        //public static void BubbleSort(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                    SWAP(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSort(Employee[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                    SWAP(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //} 
        #endregion
        #region Genrics
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T> //IComparable //ICompare
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        //if (arr[j] > arr[j + 1])
                        //if (arr[j].Compare(arr[j + 1]) > 0)
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                            SWAP(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        #endregion
        #endregion

        #region Generics Constrains
        //<T,T1,T2> where T : IComparable<T> where T2 : IComparable<T2> where T1 : IComparable<T1>
        /// Primary Constraint [0:1]
        ///  1. General Primary Constraint
        ///             Class => T Must Be Class
        ///             Struct => T Must Be Struct
        ///             NotNull => T Must Be Not Null (C# 8.0)
        ///             default => Speacial Case to use
        ///             unmanaged => not use in C#
        ///             Enum => T Must Be Enum (C# 7.x)
        /// 2. Special Primary Constraint (User-Defined Class (Except Seald))     
        ///             Point => T Must Be Point Or anthor class Inherits from point
        ///             
        /// Secondary Constraint (InterFace Constraint) [0 : M]
        /// T Must Be Class / Struct  Implementing Icomparable
        /// 
        /// paramerterless Constructor Constraint [0 : 1]
        /// T must be datatype having accessable[Non - private] parameterless constructor
        /// can't use new() [constructor constraint] with struct [special primary constraint]
        #endregion

        ///c# 11 .net 7.0
        public static T Sum<T>(T X , T Y) where T : INumber<T> 
        {
            return X + Y;
        }
    }

    class Employee : IComparable<Employee> // IComparable //ICompare
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        //public int Compare(object obj)
        //{
        //    ///this keyword : refere to object calling method
        //    //Employee left = this;
        //    //Employee right = (Employee)obj; //explicit casting [unsafe]

        //    //if ((left?.Salary ?? 0) > (right?.Salary ?? 0)) return +1;
        //    //else if ((left?.Salary ?? 0) < (right?.Salary ?? 0)) return -1;
        //    //else return 0;

        //    ///1. is type check : return true or false 
        //    ///obj is object of type "Employee"
        //    ///obj is object of type inherit from "Employee"
        //    ///obj is null
        //    //if (obj is Employee hamada) //true
        //    //{
        //    //    if (hamada is null) return +1;
        //    //    else this.Salary.CompareTo(hamada.Salary);
        //    //}
        //    //else ///obj => not null and not from employee DataType
        //    //{
        //    //    return +1;
        //    //}

        //    ///2. as casting operator : //refernece types or nullable data types
        //    ///int? test = obj as int?;
        //    Employee hamada2 = obj as Employee;
        //    if (hamada2 is null) return +1;
        //    else return this.Salary.CompareTo(hamada2.Salary);
        //}

        public int CompareTo(object? obj)
        {
            Employee hamada2 = obj as Employee;
            if (hamada2 is null) return +1;
            else return this.Salary.CompareTo(hamada2.Salary);
        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return +1;
            else return this.Salary.CompareTo(other.Salary);
        }

        public static bool operator >(Employee left, Employee right)
        {
            return (left?.Salary ?? 0) > (right?.Salary ?? 0);
        }
        public static bool operator <(Employee left, Employee right)
        {
            return (left?.Salary ?? 0) > (right?.Salary ?? 0);
        }
    }
}
