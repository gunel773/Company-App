using CompanyApp.Domain.Models;


namespace CompanyApp.Business.Interfaces
{
    public interface IEmployee
    {
        Employee Create(Employee employee, string departmentName, int experienceYear, string profession);
        Employee Update(int id, Employee employee, string departmentName);
        Employee GetEmployeeById(int id);
        List<Employee> GetAllDepartmentId(int id);
        Employee Delete(int id);
        List<Employee> GetAllAge(int age);
        List<Employee> GetAllDepartmentName(Department department);
        List<Employee> SearchEmployeeWithName(string name);
        List<Employee> GetAll();
        List<Employee> GetAllEmployeesByProfession(string profession);
        List<Employee> GetAllEmployeesByAdress(string adress);
        List<Employee> GetAllEmployeesByExperienceYear(int experienceYear);
        int GetAllEmployeesCount();


    }
}
