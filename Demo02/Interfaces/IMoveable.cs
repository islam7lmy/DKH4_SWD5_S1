using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface IMoveable
    {
        void Forward();
        void Backward();
    }

    internal interface IFlayable
    {
        void Forward();
        void Backward();
    }

    class Car : IMoveable
    {
        public void Forward() //implicit implementation
        {
            Console.WriteLine("Car is Moving Forward");
        }

        public void Backward() //implicit implementation
        {
            Console.WriteLine("Car is Moving Backward");
        }
    }

    class AirPlane : IMoveable, IFlayable
    {
        public void Backward() //implicit implementation
        {
            Console.WriteLine("AirPlane is Moving Backward");
        }

        void IMoveable.Forward() //explicit implementation
        {
            Console.WriteLine("AirPlane is Moving Forward");
        }

        void IFlayable.Forward() //explicit implementation
        {
            Console.WriteLine("AirPlane is Flying Forward");
        }
    }
}
