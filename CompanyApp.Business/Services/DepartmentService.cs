﻿
using CompanyApp.DataContext.Repositories;
using CompanyApp.Domain.Models;

namespace CompanyApp.Business.Services
{
    public class DepartmentService
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
            return department;
        }


        public Department Delete(int id)
        {
            throw new NotImplementedException();
        }



        public Department Get(string departmentName)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Department> SearchByCapacity(int capacity)
        {
            throw new NotImplementedException();
        }

        public Department Update(int id, Department department, int capacity)
        {
            throw new NotImplementedException();
        }

        internal object Get(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
