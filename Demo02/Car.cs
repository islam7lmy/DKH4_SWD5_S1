using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        #region full property [not recomended if no logic will do in get or set]
        ///full property
        //private int id;
        //public int Id
        //{
        //	get { return id; }
        //	set { id = value; }
        //}

        //private string model;
        //public string Model
        //{
        //	get { return model; }
        //	set { model = value; }
        //}

        //private int speed;
        //public int Speed
        //{
        //	get { return speed; }
        //	set { speed = value; }
        //} 
        #endregion

        /// automatic property => clr will create backing field
        public int Id;
        //public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        ///if no user-defined constructor exists
        ///clr will always generate empty parameterless constructor
        ///public car() {} => do nothing

        ///if u write user-defined constructor
        ///clr will no longer generate empty parameterless constructor
        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("ctor 01");
        }
        public Car(int _id) : this(_id , "BMW")
        {
            //Id = _id;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("ctor 02");
        }
        public Car(int _id, string _model) : this (_id,_model,120)
        {
            //Id = _id;
            //Model = _model;
            //Speed = 120;
            Console.WriteLine("ctor 03");
        }
        public Car(int _id, string _model, int _speed)
        {
            Id = _id;
            Model = _model;
            Speed = _speed;
            Console.WriteLine("ctor 04");
        }
    }
}
