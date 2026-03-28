using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal struct Employee1
    {
        public int ID;

        // Encapsulation: => Seperates The Data Defintion (Attribute) From Its Use (GetterSetter Or Property)
        string Name;  // length <= 20
        decimal salary; // salary >= 5000

        public Employee1(int _id, string _name, decimal _salary, int _age)
        {
            ID = _id;
            //Name = _name.Length <= 20 ? _name : _name.Substring(0, 20);
            SetName(_name);
            //salary = _salary >= 5000 ? _salary : 5000; // => set to data defnation
            Salary = _salary; //=> property   
            age = _age;
        }

        public override string ToString()
        {
            return $"id = {ID} , name = {Name} , salary = {salary} , age = {age}";
        }


        //setter 
        public void SetName(string value)
        {
            Name = value.Length <= 20 ? value : value.Substring(0, 20);
        }
        //getter
        public string GetName()
        {
            return Name;
        }

        ///property => Easy Use Like Attribute
        /// 1. full property [data Defintion + property]
        public decimal Salary
        {
            get { return salary; }
            //private set { salary = value; } allow in current scope of struct only
            set { salary = value; }
            //set { salary = value >= 5000 ? value : 5000; }
        }

        /// 1. automatic property [Backing filed + property]
        /// Compiler Will Generate Backing Field [Hidden Private Attribute]
        public int age { get; set; }

        public decimal Deduction { get { return Salary * .2M; } }

    }
}
