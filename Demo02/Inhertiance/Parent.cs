using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    //[base]
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        //public Parent()
        //{

        //}

        public Parent(int _x, int _y)
        {
            X = _x > 0 ? _x : 10;
            Y = _y;
        }
    }
}
