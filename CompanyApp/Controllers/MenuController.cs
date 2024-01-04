using CompanyApp.Utilities;
using static CompanyApp.Utilities.Helper;

namespace CompanyApp.Controllers
{
    public class MenuController
    {
        private readonly MenuController menu= new ();
        private readonly EmployeeController employeeController=new();
        private readonly DepartmentController departmentController=new();
        public void EmployeeSelectionListMethod()
        {
        StartEMenu: Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Select the process you want to execute:");
            Helper.ChangeTextColor(ConsoleColor.DarkCyan, "CreateEmployee\n" + "DeleteEmployee\n" + "UpdateEmployee\n" + "GetEmployeeById\n" +
                "GetAllEmployeesByDepartmentId\n" + "GetAllEmployessByAge\n" + "SearchEmployeesWithNameOrSurname\n" +
             "GetAllEmployees\n" + "GetAllEmployeesByProfession\n" + "GetAllEmployeesByAdress\n" + "GetAllEmployeesByExperienceYear\n" + "Exit\n");
        EnterEMenu: string select = Console.ReadLine();
            bool resultSelect = int.TryParse(select, out int intSelect);
            while (true)
            {
                if (resultSelect && intSelect > 0 && intSelect < 12)
                {
                    switch (intSelect)
                    {
                        case (int)EmployeeSelectionList.CreateEmployee:
                            employeeController.CreateEmployee();
                            break;
                        case (int)EmployeeSelectionList.DeleteEmployee:
                            employeeController.DeleteEmployee();
                            break;
                        case (int)EmployeeSelectionList.UpdateEmployee:
                            employeeController.UpdateEmployee();
                            break;
                        case (int)EmployeeSelectionList.GetEmployeeById:
                            employeeController.GetEmployeeById();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployeesByDepartmentId:
                            employeeController.GetAllEmployeesByDepartmentId();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployessByAge:
                            employeeController.GetAllEmployeesByAge();
                            break;
                        case (int)EmployeeSelectionList.SearchEmployeesWithNameOrSurname:
                            employeeController.SearchEmployeesWithNameOrSurname();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployees:
                            employeeController.GetAllEmployess();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployeesByProfession:
                            employeeController.GetAllEmployeesByProfession();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployeesByAdress:
                            employeeController.GetAllEmployeesByAdress();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployeesByExperienceYear:
                            employeeController.GetAllEmployeesByExperienceYear();
                            break;

                        default:
                            break;

                    }
                    goto StartEMenu;
                }
                else if (intSelect == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, "Logged out...");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "There is no such selection");
                    goto EnterEMenu;
                }

            }

        }

        public void DepartmentSelectionListMethod()
        {
        StartDMenu: Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Select the process you want to execute:");
            Helper.ChangeTextColor(ConsoleColor.DarkCyan, "CreateDepartment\n" + "DeleteDepartment\n" + "UpdateDepartment\n" + "GetDepartmentById\n" +
                "GetAllDepartment\n" + "GetDepartmentByName\n" + "SearchDepartmentsByCapacity\n" + "Exit\n");
        EnterDMenu: string select = Console.ReadLine();
            bool resultSelect = int.TryParse(select, out int intSelect);
            while (true)
            {
                if (resultSelect && intSelect > 0 && intSelect < 8)
                {
                    switch (intSelect)
                    {
                        case (int)DepartmentSelectionList.CreateDepartment:
                            departmentController.CreateDepartment();
                            break;
                        case (int)DepartmentSelectionList.DeleteDepartment:
                            departmentController.DeleteDepartment();
                            break;
                        case (int)DepartmentSelectionList.UpdateDepartment:
                            departmentController.UpdateDepartment();
                            break;
                        case (int)DepartmentSelectionList.GetDepartmentById:
                            departmentController.GetDepartmentById();
                            break;
                        case (int)DepartmentSelectionList.GetAllDepartment:
                            departmentController.GetAllDepartment();
                            break;
                        case (int)DepartmentSelectionList.GetDepartmentByName:
                            departmentController.GetDepartmentByName();
                            break;
                        case (int)DepartmentSelectionList.SearchDepartmentsByCapacity:
                            departmentController.SearchDepartmentsByCapacity();
                            break;

                        default:
                            break;

                    }
                    goto StartDMenu;
                }
                else if (intSelect == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, "Logged out...");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "There is no such selection");
                    goto EnterDMenu;
                }

            }

        }

        public void Menu()
        {
        Start: Helper.ChangeTextColor(ConsoleColor.DarkCyan, "What category will your processes be in?\n" + "Select:\n"
                                                        + " 1--EmployeeSelectionList\n " + "2--DepartmentSelectionList\n");
        Enter: string selection = Console.ReadLine();
            bool result = int.TryParse(selection, out int intselection);
            while (true)
            {
                if (result && intselection > 0 && intselection < 3)
                {
                    switch (intselection)
                    {
                        case (int)SelectionList.EmployeeSelectionList:
                            menu.EmployeeSelectionListMethod();
                            break;
                        case (int)SelectionList.DepartmentSelectionList:
                            menu.DepartmentSelectionListMethod();
                            break;

                        default:
                            break;

                    }
                    goto Start;
                }
                else if (intselection == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, "Logged out...");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "There is no such selection");
                    goto Enter;
                }

            }

        }
    }
}
