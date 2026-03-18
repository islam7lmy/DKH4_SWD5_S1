using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    //[drived]
    internal class Child : Parent
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        public int Z { get; set; }


        //public Child() : base(10,20)
        //{
        //}

        public Child(int _x, int _y, int _z) : base(_x, _y)
        {
            //X = _x;
            //Y = _y;
            Z = _z;
        }
    }
}
