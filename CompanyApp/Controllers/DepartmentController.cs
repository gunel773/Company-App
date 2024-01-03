

using CompanyApp.Business.Services;
using CompanyApp.Domain.Models;
using CompanyApp.Utilities;

namespace CompanyApp.Controllers
{

    public class DepartmentController
    {
        private readonly DepartmentService departmentService;
        public DepartmentController()
        {
            departmentService = new ();
        }

        public void CreateDepartment()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Department Name:");
            string departmentName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Department capacity");
            string capacity = Console.ReadLine();

            bool result = int.TryParse(capacity, out int departmentCapacity);
            if (result)
            {
                Department newdepartment = new();
                newdepartment.DepartmentName = departmentName;
                newdepartment.Capacity = departmentCapacity;

                var createddepartment = departmentService.Create(newdepartment, departmentCapacity);
                if (createddepartment is not null)
                {
                    Helper.ChangeTextColor(ConsoleColor
                        .DarkGreen, $"Department named {newdepartment.DepartmentName} was created.");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong...Try again... ");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "You enter correct capacity ");
            }

        }



    }
} 
