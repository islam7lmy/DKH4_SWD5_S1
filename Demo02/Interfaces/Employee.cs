using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class Employee : ICloneable,IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        /// default constructor => empty parameterless constructor
        public Employee()
        {
            
        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        /// and initializes the new object with the values of the existing object.
        public Employee(Employee emp)
        {
            /// this keyword is used to refer to the current instance of the class.
            /// base keyword is used to refer to the base class of the current class.

            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Salary = emp.Salary;
            this.Address = emp.Address;
            this.Password = emp.Password;
        }

        public static Employee DeepCopy(Employee emp)
        {
            //return new Employee
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Salary = emp.Salary,
            //    Address = emp.Address,
            //    Password = emp.Password
            //};

            return new Employee(emp);
        }

        /// standard method to create a copy of an object is to implement 
        /// the ICloneable interface and its Clone method.
        public object Clone()
        {
            //return new Employee
            //{
            //    /// this keyword is used to refer to the current instance that calling Method.
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary,
            //    Address = this.Address,
            //    Password = this.Password
            //};

            return new Employee(this);
        }

        ///+ve : this > obj
        ///-ve : this < obj
        ///0 : this == obj
        public int CompareTo(object? obj)
        {
            Employee other = (Employee) obj; ///explicit casting , unsafe casting
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }
    }


}
