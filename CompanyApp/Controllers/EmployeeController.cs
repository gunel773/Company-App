

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
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the name of the department where the employee will be included:");
            string departmentName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the employee's name:");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the employee's surname:");
            string surName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the employee's age:");
            int age = int.Parse(Console.ReadLine());
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the employee's profession:");
            string profession = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter how many years of work experience the employee has:");
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
                Helper.ChangeTextColor(ConsoleColor.Green, "Telebe created");
            }
        }
    }
 }

