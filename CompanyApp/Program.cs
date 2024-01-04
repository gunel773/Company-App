// See https://aka.ms/new-console-template for more information
using CompanyApp.Controllers;
using CompanyApp.Utilities;

Helper.ChangeTextColor(ConsoleColor.DarkCyan, "CompanyApp");
 DepartmentController departmentController = new ();
EmployeeController employeeController = new  ();  
departmentController.CreateDepartment();
//employeeController.CreateEmployee();

//departmentController.DeleteDepartment();
//employeeController.DeleteEmployee();
//departmentController.UpdateDepartment();
//employeeController.UpdateEmployee();
//departmentController.GetDepartmentByName();
departmentController.GetDepartmentById();
