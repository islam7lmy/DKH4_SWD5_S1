using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }


        //public override bool Equals(object? obj)
        //{
        //    //this keyword  => refer to object that call method
        //    Point other = obj as Point;

        //    if(other == null) return false;

        //    if(this.X == other.X)
        //        return this.Y == other.Y;

        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    //Generics.Point p1 = new Generics.Point(3, 0); // old way => 3
        //    //Generics.Point p2 = new Generics.Point(0, 3); // old way => 3
        //    //if two things are equal(Equals(..) == true) then they must return the same value of gethashcode()
        //    //if the gethashcoe() is equal, it is not necessry for them to be the same;
        //    //this collision , Equals will be called to see if it is real equality or not

        //    //return X.GetHashCode() + Y.GetHashCode();

        //    //C# 8.0
        //    return HashCode.Combine(X, Y);
        //}


    }
}
