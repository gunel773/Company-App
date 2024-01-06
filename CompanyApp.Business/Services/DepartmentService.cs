
using CompanyApp.Business.Interfaces;
using CompanyApp.DataContext.Repositories;
using CompanyApp.Domain.Models;

namespace CompanyApp.Business.Services
{
    public class DepartmentService:IDepartment
    {

        private readonly DepartmentRepository departmentRepository;
        private readonly EmployeeRepository employeeRepository;
        private static int Count = 1;

        public DepartmentService()
        {
            departmentRepository = new();
            employeeRepository = new();
        }

        public Department Create(Department department, int capacity)
        {
            var existDepartmentName = departmentRepository.Get(d => d.DepartmentName.Equals(department.Name, StringComparison.OrdinalIgnoreCase));
            if (existDepartmentName is not null) return null;
            department.Id = Count;
            if (departmentRepository.Create(department))
            if (!(department.Capacity > 0)) return null;
            Count++;
             return department;
                
               
        }

        public Department Delete(int id)
        {
            var existDepartment = departmentRepository.Get(d => d.Id == id);
            if (existDepartment is null) return null;
            if (departmentRepository.Delete(existDepartment))
            {
                var employeeList = employeeRepository.GetAll(e => e.Department.Id == id);
                if (employeeList.Count > 0)
                {
                    foreach (var employee in employeeList)
                    {
                        employeeRepository.Delete(employee);
                    }
                }
                return existDepartment;

            }
            return null;
         }

        public Department Get(int id)
        {
            var existDepartment=departmentRepository.Get(d=>d.Id == id);
            if (existDepartment is null) return null;
             return existDepartment;

        }

        public List<Department> GetAll()
        {
            return departmentRepository.GetAll();
        }


        public List<Department> SearchByCapacity(int capacity)
        {
           
            var existDepartments= departmentRepository
               .GetAll(d => d.Capacity == capacity);
            if (existDepartments is null) return null;
            return existDepartments;


        }

        public Department Update(int id, Department department, int capacity)
        {
            var existDepartment = departmentRepository.Get(d => d.Id == id);
            if (existDepartment is null) return null;

            var existDepartmentName = departmentRepository
                .Get(d => d.DepartmentName.Equals(department.DepartmentName, StringComparison.OrdinalIgnoreCase) && d.Id != existDepartment.Id);
            if (existDepartmentName != null) return null;
            if (existDepartment.Capacity > department.Capacity) return null;
            existDepartment.DepartmentName = department.DepartmentName;
            existDepartment.Capacity = department.Capacity;

            if (departmentRepository.Update(department))
            {
                return existDepartment;
            }
            return null;

        }

        public Department Get(string departmentName)
        {
            var existDepartment = departmentRepository.Get(d => d.DepartmentName == departmentName);
            if (existDepartment is null) return null;
            return existDepartment;
        }
    }
}
