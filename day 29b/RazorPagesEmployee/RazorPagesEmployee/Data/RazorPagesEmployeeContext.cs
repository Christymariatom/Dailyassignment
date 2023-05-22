using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesEmployee.Models;

namespace RazorPagesEmployee.Data
{
    public class RazorPagesEmployeeContext : DbContext
    {
        public RazorPagesEmployeeContext (DbContextOptions<RazorPagesEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesEmployee.Models.Employee> Employee { get; set; } = default!;
    }
}
