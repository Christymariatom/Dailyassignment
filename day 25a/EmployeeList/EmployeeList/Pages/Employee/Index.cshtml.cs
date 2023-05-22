using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeList.Data;
using EmployeeList.Model;

namespace EmployeeList.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeList.Data.EmployeeListContext _context;

        public IndexModel(EmployeeList.Data.EmployeeListContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = (IList<EmployeeListContext>)await _context.Employee.ToListAsync();
            }
        }
    }
}
