

using CompanyApp.Domain.Models;

namespace CompanyApp.DataContext
{
    public static class DbContext
    {
        public static List<Department> Departments { get; set; }
        public static List<Employee> Employees { get; set; }
        static DbContext()
        {
            Employees = new();
            Departments = new();
        }
    }
}
