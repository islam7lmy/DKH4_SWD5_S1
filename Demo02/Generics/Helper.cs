using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal static class Helper
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
        public static void SWAP<T>(ref T x ,ref T y)
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
    }
}
