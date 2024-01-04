using CompanyApp.Business.Interfaces;
using CompanyApp.DataContext.Repositories;
using CompanyApp.Domain.Models;


namespace CompanyApp.Business.Services
{
    public class EmployeeService:IEmployee
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly DepartmentRepository _departmentRepository;
        private static int Count = 1;
        public EmployeeService()
        {
            _departmentRepository = new();
            _employeeRepository = new();
        }
        public Employee Create(Employee employee, string departmentName, int experienceYear, string profession)
        {
            var existDepartment = _departmentRepository
                .Get(d => d.DepartmentName.Equals(departmentName, StringComparison.OrdinalIgnoreCase));
            if (existDepartment is null) return null; 
            employee.Id = Count;
            employee.Department = existDepartment;
            bool result = _employeeRepository.Create(employee);
            if (!result) return null;
            Count++;
            return employee;
        }




        public Employee Delete(int id)
        {
            var existEmployee=_employeeRepository.Get(e=>e.Id == id);
            if (existEmployee is null) return null;
            if (_employeeRepository.Delete(existEmployee)) return existEmployee;
            return null;

        }



        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllAge(int age)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllDepartmentId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllDepartmentName(Department department)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployeesByAdress(string adress)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployeesByAge(int age)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployeesByDepartmentId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployeesByExperienceYear(int experienceYear)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployeesByProfession(string profession)
        {
            throw new NotImplementedException();
        }

        public int GetAllEmployeesCount()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployessByDepartmentName(Department department)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> SearchEmployeeWithName(string name)
        {
            throw new NotImplementedException();
        }

        public Employee Update(int id, Employee employee, string departmentName)
        {
            var existEmployee = _employeeRepository.Get(e => e.Id == id);
            if (existEmployee is null) return null;
            var existDepartment = _departmentRepository.Get(d => d.DepartmentName == departmentName);
            if (existDepartment is null) return null;

            if (string.IsNullOrEmpty(employee.Name)) existEmployee.Name = employee.Name;
            if (string.IsNullOrEmpty(employee.Surname)) existEmployee.Surname = employee.Surname;
            existEmployee.Department = existDepartment;

            if (_employeeRepository.Update(existEmployee))
            {
                return existEmployee;
            }
            else
            {
                return null;
            }


        }

    }
}
