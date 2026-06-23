using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer" -v "7.0"
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion

            #region CRUD Operations [create, read, update, delete]
            ///unmanaged
            //CompanyDbContext dbContext = new CompanyDbContext();
            //try
            //{
            //    ///CRUD
            //}
            //catch (Exception ex) 
            //{ 

            //}
            //finally
            //{
            //    dbContext.Dispose(); //[release | Close] DbConnetion
            //}

            //using (CompanyDbContext dbContext = new CompanyDbContext())
            //{
            //    ///CRUD
            //}

            //using CompanyDbContext dbContext = new CompanyDbContext();

            //Employee E01 = new Employee()
            //{
            //    Name = "A",
            //    Salary = 1000,
            //    Age = 30
            //};

            //Employee E02 = new Employee()
            //{
            //    Name = "B",
            //    Salary = 4000,
            //    Age = 27
            //};


            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            #region Create
            //dbContext.Employees.Add(E01);
            //dbContext.Set<Employee>().Add(E01);
            //dbContext.Add(E01);
            //dbContext.Entry(E01).State = EntityState.Added;

            //Console.WriteLine(dbContext.Entry(E01).State);
            //dbContext.Employees.Add(E01);
            //Console.WriteLine(dbContext.Entry(E01).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(E01).State);
            #endregion

            #region Read
            #region Multi Elements
            //Iqueryable<Employee> Result => generate SQL Query
            //var Result = from emp in dbContext.Employees
            //             where emp.Id == 1
            //             select emp; //linq query => select * from Employees where Id = 1

            //IEnumerable<Employee> Result => execute SQL Query
            //var Result2 = (from emp in dbContext.Employees
            //               where emp.Id == 1
            //               select emp).ToList();

            //var Result2 = dbContext.Employees.Where(emp => emp.Id == 1).ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Id : {item.Id}, Name {item.Name}");
            //}
            #endregion
            #region One Element
            //var Emp = (from emp in dbContext.Employees
            //           where emp.Id ==1
            //           select emp)
            //           //.First(); ///top(1) ////linq query => select top(1) * from Employees where Id = 1
            //           //.FirstOrDefault();///top(1) or null ////linq query => select top(1) * from Employees where Id = 1
            //           //.Single();///top(2) ////linq query => select top(2) * from Employees where Id = 1
            //           .SingleOrDefault();///top(2) or null ////linq query => select top(2) * from Employees where Id = 1
            //Console.WriteLine($"Id: {Emp.Id}, Name: {Emp.Name}, Salary: {Emp.Salary}, Age: {Emp.Age}");
            #endregion
            #region Tracking vs notracking
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll; ///default
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; ///
            //var result = dbContext.Employees.Where(emp => emp.Id == 1).AsTracking().FirstOrDefault();
            //var result2 = dbContext.Employees.Where(emp => emp.Id == 1).AsNoTracking().FirstOrDefault();
            ////var result2 = (from emp in dbContext.Employees
            ////               where emp.Id == 1
            ////               select emp);
            //Console.WriteLine(dbContext.Entry(result).State);
            //Console.WriteLine(dbContext.Entry(result2).State);
            #endregion
            #endregion

            #region Update
            //var result = dbContext.Employees.Where(e => e.Id == 1).FirstOrDefault();
            //if (result is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(result).State);
            //    result.Name = "Updated Name";
            //    Console.WriteLine(dbContext.Entry(result).State);
            //    dbContext.Employees.Update(result);
            //    Console.WriteLine(dbContext.Entry(result).State);
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(result).State);
            //}
            #endregion

            #region Delete
            //var result = dbContext.Employees.Where(e => e.Id == 1).FirstOrDefault(); //db
            //var result2 = dbContext.Employees.Find(1); // change trcker => local cache => db

            //if (result is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(result).State);
            //    dbContext.Employees.Remove(result);
            //    Console.WriteLine(dbContext.Entry(result).State);
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(result).State);
            //}
            #endregion

            #endregion

            #region Mapping RealtionShip
            //pk => fk
            ///3. how to implment in code
            ///       3.1 fk property [class name + pk name]
            ///       3.2 Navigational property [class name]
            ///       by default EF will use convention to map the relationship
            #endregion
        }
    }
}
