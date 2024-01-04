// See https://aka.ms/new-console-template for more information
using CompanyApp.Controllers;
using CompanyApp.Utilities;

Helper.ChangeTextColor(ConsoleColor.DarkCyan, "CompanyApp");
 DepartmentController departmentController = new ();
EmployeeController employeeController = new  ();
departmentController.CreateDepartment();
//departmentController.DeleteDepartment();
//departmentController.UpdateDepartment();
//departmentController.GetDepartmentByName();
//departmentController.GetDepartmentById();
//departmentController.GetAllDepartment();
//departmentController.SearchDepartmentByCapacity();

 employeeController.CreateEmployee();
 employeeController.CreateEmployee();
 //employeeController.CreateEmployee();


//employeeController.DeleteEmployee();
//employeeController.UpdateEmployee();
//employeeController.GetEmployeeById();
//employeeController.GetAllEmployeesByDepartmentId();
//employeeController.GetAllEmployeesByAge()
//employeeController.GetAllEmployess();
//employeeController.SearchEmployeeWithNameOrSurname();
//employeeController.GetAllEmployeesByProfession();
//employeeController.GetAllEmployeesByAdress();////



