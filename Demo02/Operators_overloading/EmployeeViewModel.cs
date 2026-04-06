using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operators_overloading
{
    class Employee //model
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal detuctions { get { return Salary * .2m; } }

        public EmployeeViewModel ToViewModel(Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.detuctions,
            };
        }
    }

    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal NetSalary { get; set; }

        public override string ToString()
        {
            return $"Name : {FullName}\nAge : {Age}\nAddress : {Address}\nSalary : {NetSalary}";
        }

        ///user defined Explicit Casting operator
        public static explicit operator EmployeeViewModel(Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.detuctions,
            };
        }

        ///Manual Mapping
        public static EmployeeViewModel FromEmployee(Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.detuctions,
            };
        }
    }

    static class EmployeeExtensions
    {
        public static EmployeeViewModel ToViewModel(this Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.detuctions,
            };
        }
    }
}
