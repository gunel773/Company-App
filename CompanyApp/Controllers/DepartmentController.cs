

using CompanyApp.Business.Services;
using CompanyApp.Domain.Models;
using CompanyApp.Utilities;
using System.Text.RegularExpressions;

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
                        .DarkGreen, $"Department named {newdepartment.DepartmentName} has been successfully created.");
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



        public void DeleteDepartment()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the İD of the department you want to delete");
            int deartmentId= int.Parse(Console.ReadLine());
            var result = departmentService.Delete(deartmentId);

            if (result is null)
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong..");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Green, "Department has been successfully deleted");
            }



        }
        public void UpdateDepartment()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the department İD you want to change");
            int id = int.Parse(Console.ReadLine());

            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter department capacity");
            int capacity = int.Parse(Console.ReadLine());

            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter department name");
            string departmentName = Console.ReadLine();

            Department newDepartment = new();
            newDepartment.DepartmentName = departmentName;
            newDepartment.Capacity = capacity;
            var createdDepartment = departmentService.Update(id, newDepartment, capacity);


            if (createdDepartment != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green, $"{newDepartment.Name} department uptaded");

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong");
            }
        }

        public void GetDepartmentById()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the ID of the Department you are looking for");
            int id = int.Parse(Console.ReadLine());
            var result = departmentService.Get(id);
            if (result is not null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green, $"The Department you are looking for:Id:{id}  Department Name:{result.DepartmentName}  Capacity:{result.Capacity}");

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $" Department with {id} Id not found");
            }
        }

        public void GetAllDepartment()
        {
            //Helper.ChangeTextColor(ConsoleColor.Yellow, "Student list : ");
            //var students = _studentService.GetAll();
            //if (students.Count > 0)
            //{
            //    foreach (var student in students)
            //    {
            //        Helper.ChangeTextColor(ConsoleColor.Green, $"Id:{student.Id} Name: {student.Name}  Group:{student.Group.Name}");
            //    }
            //}
            //else
            //{
            //    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list");
            //}
        }

        public void GetDepartmentByName()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter the name of the Department you are looking for");
            string departmentName= Console.ReadLine();
            var result=departmentService.Get(departmentName);
            if(result is not null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green, $"The Department you are looking for:Id:{result.Id}  Department Name:{departmentName}  Capacity:{result.Capacity}");

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"{departmentName} Department not found");
            }
           
        }


    }
} 
