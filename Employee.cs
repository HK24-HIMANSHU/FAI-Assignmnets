using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RecapMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; } =string.Empty;
        public string Email { get; set; }=string.Empty;
        public int Salary { get; set; }
    }
    public class EmployeeDBContext: DbContext
    {
        public DbSet<Employee> Employees { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string STRCON = @"Data Source=W-674PY03-1;Initial Catalog=Himanshu1Db;Persist Security Info=True;User ID=sa;Password=Password@12345; TrustServerCertificate=True"; 
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(STRCON);
        }
    }
}
