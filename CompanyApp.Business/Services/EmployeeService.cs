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

        public Employee GetById(int id)
        {
            var existEmployee=_employeeRepository
                .Get(e=>e.Id == id);
            if (existEmployee is null) return null;
            return existEmployee;
        }

        public List<Employee> GetAllByDepartmentId(int id) 
        {
            var existEmployees=_employeeRepository
                .GetAll(e=> e.Department.Id == id);    
            if (existEmployees is null) return null;
            return existEmployees;
           

        }

        public List<Employee> GetAllByAge(int age)
        {
            var existEmployees = _employeeRepository
                .GetAll(e => e.Age == age);
            if (existEmployees is null) return null;
            return existEmployees;
        }

        public List<Employee> SearchWithNameOrSurname(string name)
        {
            var existEmployees = _employeeRepository
               .GetAll(e => e.Name == name || e.Surname==name);
            if (existEmployees is null) return null;
            return existEmployees;
        }

        public List<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public List<Employee> GetAllByProfession(string profession)
        {
            var existEmployees = _employeeRepository
                .GetAll(e => e.Profession == profession);
            if (existEmployees is null) return null;
            return existEmployees;
        }

        public List<Employee> GetAllsByAdress(string adress)
        {
            var existEmployees = _employeeRepository
                .GetAll(e => e.Adress == adress);
            if (existEmployees is null) return null;
            return existEmployees;
        }

        public List<Employee> GetAllByExperienceYear(int experienceYear)
        {
            var existEmployees = _employeeRepository
                .GetAll(e => e.ExperienceYear == experienceYear);
            if (existEmployees is null) return null;
            return existEmployees;
        }

        public int GetAllEmployeesCount()
        {
            throw new NotImplementedException();
        }

        
    }
}
