using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesEmployee.Data;
using RazorPagesEmployee.Models;

namespace RazorPagesEmployee.Pages.Employes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesEmployee.Data.RazorPagesEmployeeContext _context;

        public IndexModel(RazorPagesEmployee.Data.RazorPagesEmployeeContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
