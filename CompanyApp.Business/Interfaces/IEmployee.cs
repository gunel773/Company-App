using CompanyApp.Domain.Models;


namespace CompanyApp.Business.Interfaces
{
    public interface IEmployee
    {
        Employee Create(Employee employee, string departmentName, int experienceYear, int age);
        Employee Update(int id, Employee employee, string departmentName);
        Employee Delete(int id);
        Employee GetById(int id);
        List<Employee> GetAllByDepartmentId(int id);
        List<Employee> SearchWithNameOrSurname(string name);
        List<Employee> GetAll();
        List<Employee> GetAllByProfession(string profession);
        List<Employee> GetAllsByAdress(string adress);
        List<Employee> GetAllByExperienceYear(int experienceYear);
        List<Employee> GetAllEmployeesCount();
        List<Employee> GetAllByAge(int age);
        List<Employee> GetAllBySalary(int salary);

        List<Employee> GetAllByPension(int pension);
        List<Employee> GetAllPensionByExperienceYear(int experienceYear);
        Employee GetPensionById(int id);


        


    }
}
