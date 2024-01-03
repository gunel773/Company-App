

using CompanyApp.Business.Services;
using CompanyApp.Domain.Models;

namespace CompanyApp.Controllers
{
    public class EmployeeController
    {

        private readonly EmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new();
        }

        public void CreateEmployee()
        {
        }
    }
}
