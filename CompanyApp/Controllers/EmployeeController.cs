

using CompanyApp.Business.Services;
using CompanyApp.Domain.Models;
using CompanyApp.Utilities;

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
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the name of the department where the employee will be included:");
            string departmentName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's name:");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's surname:");
            string surName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's age:");
            int age = int.Parse(Console.ReadLine());
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's profession:");
            string profession = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter how many years of work experience the employee has:");
            int experienceYear = int.Parse(Console.ReadLine());

            Employee newEmployee = new();
            newEmployee.Name = name;
            newEmployee.Surname = surName;
            newEmployee.Age = age;
            newEmployee.Profession = profession;
            newEmployee.ExperienceYear = experienceYear;



            if (_employeeService.Create(newEmployee, departmentName, experienceYear, profession) is null)
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong..");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Green, "Telebe has been successfully created");
            }
        }

        public void DeleteEmployee()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the İD of the Employee you want to delete");
            int employeeId = int.Parse(Console.ReadLine());
            var result = _employeeService.Delete(employeeId);

            if (result is null)
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong..");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Green, "Employee has been successfully deleted");
            }
        }

        public void UpdateEmployee()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee İD you want to change");
            int id = int.Parse(Console.ReadLine());


            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the name of the employee's department");
            string departmentName = Console.ReadLine();


            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter new Employee Name");
            string name = Console.ReadLine();

            Helper.ChangeTextColor(ConsoleColor.DarkMagenta,"Enter new Employee SurName");
            string surName = Console.ReadLine();

            Employee newEmployee = new();
            newEmployee.Name = name;
            newEmployee.Surname = surName;


            if (_employeeService.Update(id, newEmployee, departmentName) is null)
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong..");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Green, "Employee updated");
            }
        }
    }
 }

