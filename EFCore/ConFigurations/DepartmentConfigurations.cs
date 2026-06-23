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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> d)
        {
            d.ToTable("DepartmentInfo", "dbo")
                .HasKey(d => d.DeptId);

            d.Property(d => d.DeptId)
            .UseIdentityColumn(10, 10);

            d.Property(d => d.Name)
            .HasColumnName("DepartmentName")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

            d.Property(d => d.CreationDate)
            .HasColumnType("date")
            .HasComputedColumnSql("GETDATE()");

            //d.HasMany(d => d.Employees) //departement has many employees
            //    .WithOne(e => e.Department) //employee has one department
            //    .HasForeignKey(e => e.DepartmentDeptId) //foreign key in employee table
            //    .OnDelete(DeleteBehavior.NoAction);


            //d.HasOne(d=>d.Manger) //department has one manager
            //    .WithOne(e=>e.DepartmentToManage) //employee manages one department
            //    .HasForeignKey<Department>(d=>d.MangerId) //foreign key in department table
            //    .OnDelete(DeleteBehavior.NoAction);

            d.HasOne<Employee>()
                .WithOne()
                .HasForeignKey<Department>(d => d.MangerId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
