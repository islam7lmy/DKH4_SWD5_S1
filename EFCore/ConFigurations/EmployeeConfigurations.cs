using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.ConFigurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property<string>("Address")
            .HasColumnType("nvarchar(100)");

            //builder.HasOne(e=>e.Department) //employee has one department
            //    .WithMany(d=>d.Employees) //department has many employees
            //    .HasForeignKey(e=>e.DepartmentDeptId) //foreign key in employee table
            //    .OnDelete(DeleteBehavior.NoAction); 

            builder.HasOne<Department>()
                .WithMany()
                .HasForeignKey(e => e.DepartmentDeptId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(e=>e.DepartmentToManage) //employee has one department to manage
            //    .WithOne(d=>d.Manger) //department has one manager
            //    .HasForeignKey<Department>(d=>d.MangerId) //foreign key in department table
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
