using EFCoreNavigationalProperties.Contexts;
using EFCoreNavigationalProperties.Entites;
using Microsoft.EntityFrameworkCore;

namespace EFCoreNavigationalProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///1.Loading Navigational Properties
            ///     1.1.byDefault
            ///     1.2.Explicit
            ///     1.3.Eager
            ///     1.4.Lazy
            ///     1.5.Explicit vs Eager vs Lazy
            ///2.LINQ Join Operators - Join(), GroupJoin()
            ///     2.1.Innerjoin
            ///     2.2.Groupjoin
            ///     2.3.Leftjoin
            ///     2.4.Crossjoin

            using AppDbContext context = new AppDbContext();
            #region 1.Loading Navigational Properties
            #region 1.1.byDefault
            //var Emp = (from e in context.Employees
            //          where e.Id == 1
            //          select e).FirstOrDefault();

            //if(Emp is not null)
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, DepartmentId = {Emp.DepartmentId},  Department = {Emp.Department?.Name ?? "NA"}");
            #endregion
            #region 1.2.Explicit
            //var Emp = (from e in context.Employees
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //{
            //    context.Entry(Emp).Reference(e => e.Department).Load(); //loading refence one
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, DepartmentId = {Emp.DepartmentId},  Department = {Emp.Department?.Name ?? "NA"}");
            //}
            //////////////////////////////////////////////////////////////
            //var Dept = (from d in context.Departments
            //            where d.Id == 10
            //            select d).FirstOrDefault();
            //if (Dept is not null)
            //{
            //    context.Entry(Dept).Collection(d=>d.Employees).Load(); //loading collection many
            //    Console.WriteLine($"Department: Id = {Dept.Id}, Name = {Dept.Name}, CreationDate = {Dept.CreationDate}");
            //    foreach (var emp in Dept.Employees)
            //    {
            //        Console.WriteLine($"\tEmployee: Id = {emp.Id}, Name = {emp.Name}, DepartmentId = {emp.DepartmentId}");
            //    }
            //}

            #endregion
            #region 1.3.Eager
            //var Emp = (from e in context.Employees
            //           .Include(e => e.Department)
            //               //.Include(e=>e.Department).ThenInclude(d=>d.Project)
            //               //.Include(e=>e.Department).ThenInclude(d=>d.product)
            //               //.Include(e=>e.Dependents)
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, DepartmentId = {Emp.DepartmentId},  Department = {Emp.Department?.Name ?? "NA"}");
            #endregion
            #region 1.4.Lazy
            //var Emp = (from e in context.Employees
            //           //.Include(e => e.Department)
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, DepartmentId = {Emp.DepartmentId},  Department = {Emp.Department?.Name ?? "NA"}");

            #endregion
            #endregion

            #region 2.LINQ Join Operators
            #region 2.1.Innerjoin
            #region Query Exprission
            //var result = from D in context.Departments
            //             join E in context.Employees
            //             on D.Id equals E.DepartmentId
            //             select new
            //             {
            //                 DepartmentId = D.Id,
            //                 DepartmentName = D.Name,
            //                 EmployeeId = E.Id,
            //                 EmployeeName = E.Name
            //             };
            #endregion
            #region Falunt Exprission
            //var result2 = context.Departments.Join(
            //    context.Employees,
            //    d=>d.Id,
            //    e=>e.DepartmentId,
            //    (D,E) => new
            //    {
            //        DepartmentId = D.Id,
            //        DepartmentName = D.Name,
            //        EmployeeId = E.Id,
            //        EmployeeName = E.Name
            //    });
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2.2.Groupjoin
            #region Query Exprission
            //var result = from D in context.Departments
            //             join E in context.Employees
            //             on D.Id equals E.DepartmentId into EmpGroup
            //             select new
            //             {
            //                 Department = D,
            //                 Employees = EmpGroup
            //             };
            #endregion
            #region Falunt Exprission
            //var result2 = context.Departments.GroupJoin(
            //    context.Employees,
            //    d => d.Id,
            //    e => e.DepartmentId,
            //    (D, E) => new
            //    {
            //        Department = D,
            //        Employees = E
            //    });
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Department: Id = {item.Department.Id}, Name = {item.Department.Name}");
            //    foreach (var emp in item.Employees)
            //    {
            //        Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    }
            //}

            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"Department: Id = {item.Department.Id}, Name = {item.Department.Name}");
            //    foreach (var emp in item.Employees)
            //    {
            //        Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    }
            //}
            #endregion
            #region 2.3.Leftjoin
            #region Query Exprission
            //var result = from D in context.Departments
            //             join E in context.Employees
            //             on D.Id equals E.DepartmentId into EmpGroup
            //             ////////////////////////////////////////////
            //             from Emp in EmpGroup.DefaultIfEmpty()
            //             select new
            //             {
            //                 Department = D,
            //                 Employee = Emp
            //             };

            //var result2 = from E in context.Employees
            //              join D in context.Departments
            //              on E.DepartmentId equals D.Id into DeptGroup
            //              ////////////////////////////////////////////
            //              from Dept in DeptGroup.DefaultIfEmpty()
            //              select new
            //              {
            //                  Department = Dept,
            //                  Employee = E
            //              };
            #endregion
            #region Falunt Exprission
            //var result3 = context.Departments.GroupJoin(
            //   context.Employees,
            //   d => d.Id,
            //   e => e.DepartmentId,
            //   (D, E) => new
            //   {
            //       Department = D,
            //       Employees = E.DefaultIfEmpty()
            //   })
            //   .SelectMany(x => x.Employees, (x, em) => new { Employee = em, Department = x.Department });

            //var result4 = context.Employees.GroupJoin(
            //   context.Departments,
            //   e => e.DepartmentId,
            //   d => d.Id,
            //   (E,D) => new
            //   {
            //       Employee = E,
            //       Departments = D.DefaultIfEmpty(),
            //   })
            //   .SelectMany(x => x.Departments, (x, dp) => new { Employee = x.Employee, Department = dp });


            #endregion

            //foreach (var item in result3)
            //{
            //    Console.WriteLine($"Department: Id = {item.Department.Id}, Name = {item.Department.Name}");
            //    if (item.Employee is not null)
            //    {
            //        Console.WriteLine($".............Employee: Id = {item.Employee.Id}, Name = {item.Employee.Name}, Department = {item.Employee.Department?.Name ?? "NA"}");
            //    }
            //    else
            //    {
            //        Console.WriteLine(".............Employee: NA");
            //    }
            //}

            //foreach (var item in result4)
            //{
            //    Console.WriteLine($"Employee: Id = {item.Employee.Id}, Name = {item.Employee.Name}");
            //    if (item.Department is not null)
            //    {
            //        Console.WriteLine($".............Department: Id = {item.Department.Id}, Name = {item.Department.Name}");
            //    }
            //    else
            //    {
            //        Console.WriteLine(".............Department: NA");
            //    }
            //}
            #endregion
            #region 2.4.Crossjoin
            //var result = from d in context.Departments
            //             from e in context.Employees
            //             select new
            //             {
            //                 empname = e.Name,
            //                 deptname = d.Name
            //             };

            //result = context.Departments.SelectMany(
            //    d => context.Employees.Select(
            //        e => new
            //        {
            //            empname = e.Name,
            //            deptname = d.Name
            //        }));

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Employee: {item.empname}, Department: {item.deptname}");
            //}
            #endregion
            var result = context.EmployeeDepartmentView.ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"Employee: Id = {item.EmpId}, Name = {item.EmpName}, DepartmentId = {item.DepartmentId}, DepartmentName = {item.DepartmentName}");
            }
            #endregion


        }
    }
}
