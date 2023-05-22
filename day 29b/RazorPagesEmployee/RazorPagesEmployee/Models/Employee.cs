using System.ComponentModel.DataAnnotations;

namespace RazorPagesEmployee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public string? Dept { get; set; }
        public decimal Salary { get; set; }
    }
}
