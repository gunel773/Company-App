
using CompanyApp.Business.Interfaces;
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
            var departmentName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's name:");
            var name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's surname:");
            var surName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's age:");
            var age = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's adress:");
            var adress= Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's profession:");
            var profession = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter salary the employee has:");
            var salary = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter how many years of work experience the employee has:");
            var experienceYear = Console.ReadLine() ;

            bool resultAge = int.TryParse(age, out int employeeAge);
            bool resultSalary = int.TryParse(salary, out int employeeSalary);
            bool resultExperienceyear = int.TryParse(experienceYear, out int employeeExperienceyear);
            if (resultAge && resultExperienceyear && resultSalary)
            {

                Employee newEmployee = new();
                newEmployee.Salary = employeeSalary;
                newEmployee.Name = name;
                newEmployee.Surname = surName;
                newEmployee.Age = employeeAge;
                newEmployee.Profession = profession;
                newEmployee.ExperienceYear = employeeExperienceyear;
                newEmployee.Adress = adress;
                
               

                if (_employeeService.Create(newEmployee, departmentName, employeeExperienceyear, employeeAge) is not null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Employee has been successfully created");
                }
                else
                    {

                        Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong..");
                    }


            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the age or years of experience year you entered");
            }
        }

        public void DeleteEmployee()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the İD of the Employee you want to delete");
            var id = Console.ReadLine();

            bool resultİd = int.TryParse(id, out int employeeİd);
            if (resultİd)
            {

                if (_employeeService.Delete(employeeİd) is null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong..");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Employee has been successfully deleted");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the Id you entered");
            }
        }

        public void UpdateEmployee()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee İD you want to change");
            var id = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the name of the employee's department");
            string departmentName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter new Employee Name");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter new Employee SurName");
            string surName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's age:");
            var age = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's adress:");
            var adress = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the employee's profession:");
            var profession = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter salary the employee has:");
            var salary = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter how many years of work experience the employee has:");
            var experienceYear = Console.ReadLine();

            bool resultİd = int.TryParse(id, out int employeeİd);
            bool resultAge = int.TryParse(age, out int employeeAge);
            bool resultSalary = int.TryParse(salary, out int employeeSalary);
            bool resultExperienceyear = int.TryParse(experienceYear, out int employeeExperienceyear);
            if (resultİd&& resultAge && resultExperienceyear && resultSalary)
            {
                Employee newEmployee = new();
                newEmployee.Id = employeeİd;
                newEmployee.Name = name;
                newEmployee.Surname = surName;
                newEmployee.Age = employeeAge;
                newEmployee.Salary = employeeSalary;
                newEmployee.ExperienceYear = employeeExperienceyear;


                if (_employeeService.Update(employeeİd, newEmployee, departmentName) is null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong..");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Employee updated");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the Id you entered");
            }
        }

        public void GetEmployeeById()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the ID of the employee you are looking for");
            var id = Console.ReadLine();
            bool resultİd = int.TryParse(id, out int employeeİd);
            if (resultİd)
            {
                var result = _employeeService.GetById(employeeİd);
                if ( result is not null)
                {
                    Helper.ChangeTextColor(ConsoleColor
                    .Green, $"The Employee you are looking for:{employeeİd}--{result.Name} {result.Surname} " +
                    $" Age:{result.Age} Adress:{result.Adress} Profession:{result.Profession}  Experience year:{result.ExperienceYear}");

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $" Employee with {employeeİd} Id not found");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the Id you entered");
            }

        }

        public void GetAllEmployeesByDepartmentId()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter the department Id:");
            var id = Console.ReadLine();
            bool resultİd = int.TryParse(id, out int departmentId);
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Employees list : ");
            if (resultİd)
            {
                var employees = _employeeService.GetAllByDepartmentId(departmentId);
                if (employees.Count > 0)
                {
                    if (employees is not null)
                    {
                        foreach (var employee in employees)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname}  " +
                                $"Age:{employee.Age} Adress:{employee.Adress} Profession:{employee.Profession}  Experience year:{employee.ExperienceYear}");
                        }
                    }
                    else
                    {
                        Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                    }

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the Id you entered");
            }
        }

        public void GetAllEmployeesByAge()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Age:");
            var age = Console.ReadLine();
            bool resultAge=int.TryParse(age, out int employeeAge);
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Employees list : ");
            if (resultAge)
            {
                var employees = _employeeService.GetAllByAge(employeeAge);

                if (employees is not null)
                {
                    foreach (var employee in employees)
                    {
                        Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname}  " +
                            $"Age: {employeeAge} Adress:{employee.Adress} Profession:{employee.Profession}  Experience year:{employee.ExperienceYear}");
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the age you entered");
            }

        }

        public void SearchEmployeesWithNameOrSurname()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Employee name or surname");
            string nameOrSurname=Console.ReadLine();
            var employees=_employeeService.SearchWithNameOrSurname(nameOrSurname);
            if(employees is not null)
            {
                foreach (var employee in employees)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname}  " +
                            $"Age: {employee.Age} Adress:{employee.Adress} Profession:{employee.Profession}  Experience year:{employee.ExperienceYear}");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
            }
        }

        public void GetAllEmployess()
        {

            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Employee list : ");
            var employess = _employeeService.GetAll();
            if (employess.Count > 0)
            {
                
                    foreach (var employee in employess)
                    {
                        Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname}  " +
                                $"Age: {employee.Age} Adress:{employee.Adress} Profession:{employee.Profession}" +
                                $"  Experience year:{employee.ExperienceYear} Salary:{employee.Salary} Pension:{employee.Pension} manat");
                    }
                
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
            }
        }

         public void GetAllEmployeesByProfession()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Employee Profession");
            string profession = Console.ReadLine();
            var employees = _employeeService.GetAllByProfession(profession);
            if (employees.Count > 0)
            {
                if (employees is not null)
                {
                    foreach (var employee in employees)
                    {
                        Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname}  " +
                                $"Age: {employee.Age} Adress:{employee.Adress}  Profession:{profession}  Experience year:{employee.ExperienceYear}");
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
            }
        }

         public void GetAllEmployeesByAdress()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Employee Adress");
            string adress = Console.ReadLine();
            var employees = _employeeService.GetAllsByAdress(adress);
            if (employees.Count > 0)
            {
                if (employees is not null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"List of employees living in {adress} ");
                    foreach (var employee in employees)
                    {
                        Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname}");
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
            }
        }
        public void GetAllEmployeesByExperienceYear()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Employee experience year");
            var experienceyear = Console.ReadLine();
            bool resultExperienceyear = int.TryParse(experienceyear, out int employeeExperienceYear);
            if (resultExperienceyear)
            {
                var employees = _employeeService.GetAllByExperienceYear(employeeExperienceYear);
                if (employees.Count > 0)
                {
                    if (employees is not null)
                    {
                        foreach (var employee in employees)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname}  " );
                        }
                    }
                    else
                    {
                        Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the experience year you entered");
            }

        }

        public void GetEmployeesCount()
        {
           
                
            var employees = _employeeService.GetAllEmployeesCount();
            if (employees.Count > 0)
            {
                
                    Helper.ChangeTextColor(ConsoleColor.Green, $"Currently, the company has {employees.Count} employees");
             
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
            }
        }

        public void GetAllEmployeesByPension()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Employee pension");
            var pension = Console.ReadLine();
            bool resultPension = int.TryParse(pension, out int employeePension);
            if (resultPension)
            {
                var employees = _employeeService.GetAllByPension(employeePension);
                if (employees.Count > 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"The list of those currently collecting {pension} manat pension:");
                    if (employees is not null)
                    {
                        foreach (var employee in employees)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname} ");
                        }
                    }
                    else
                    {
                        Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the pension you entered");
            }
        }

        public void GetAllEmployeesPensionByExperienceYear()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Employee experience year");
            var experienceyear = Console.ReadLine();
            bool resultExperienceyear = int.TryParse(experienceyear, out int employeeExperienceYear);
            if (resultExperienceyear)
            {
                var employees = _employeeService.GetAllPensionByExperienceYear(employeeExperienceYear);
                if (employees.Count > 0)
                {
                    if (employees is not null)
                    {
                        foreach (var employee in employees)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname} Pension:{employee.Pension} manat ");
                        }
                    }
                    else
                    {
                        Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the experience year you entered");
            }


        }

        public void GetEmployeePensionById()
        {

            Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Enter Employee Id");
            var id = Console.ReadLine();
            bool resultId = int.TryParse(id, out int employeeId);
            if (resultId)
            {
                var employee = _employeeService.GetPensionById(employeeId);
                if (employee is not null)
                    {
                           
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{employee.Id}--{employee.Name} {employee.Surname} Pension:{employee.Pension} manat ");
                        
                    }
                    else
                    {
                        Helper.ChangeTextColor(ConsoleColor.Red, $"Something went wrong..");
                    }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Check the ID you entered");
            }

        }

    }
 }

