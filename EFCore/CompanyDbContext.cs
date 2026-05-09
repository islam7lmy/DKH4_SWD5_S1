using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class CompanyDbContext : DbContext
    {
        //"Data Source=ISLAM7LMYLAPVM\\ISLAM7LMY;Initial Catalog=MyCompany;User ID=sa;Password=***********;Encrypt=False"
        //"Data Source = ISLAM7LMY\\ISLAM7LMY; intial Catalog = S2E.EFMYCompany; Integrated Security = True"
        //"Data Source = ISLAM7LMY\\ISLAM7LMY; intial Catalog = S2E.EFMYCompany; User Id = sa; Password = Islam@123"
        //"Server = ISLAM7LMY\\ISLAM7LMY; Database = S2E.EFMYCompany; Trusted_Connection = True"

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = DKH4_SWD5_S1.EFMYCompany; Trusted_Connection = True; Encrypt = False");

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
