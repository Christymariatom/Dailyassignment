using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeList.Model;

namespace EmployeeList.Data
{
    public class EmployeeListContext : DbContext
    {
        public EmployeeListContext (DbContextOptions<EmployeeListContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeList.Model.Employee> Employee { get; set; } = default!;
    }
}
