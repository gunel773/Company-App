using CompanyApp.Utilities;
using static CompanyApp.Utilities.Helper;

namespace CompanyApp.Controllers
{
    public class MenuController
    {
       
        private readonly EmployeeController employeeController=new();
        private readonly DepartmentController departmentController=new();

        public void EmployeeSelectionListMethod()
        {
        StartEMenu: Helper.ChangeTextColor(ConsoleColor.DarkBlue, "A selection list of prosessing methods on employees\n"+
            "Select the process you want to execute:\n");
           Helper.ChangeTextColor(ConsoleColor.DarkCyan, "1-CreateEmployee\n" + "2-DeleteEmployee\n" + "3-UpdateEmployee\n" + "4-GetEmployeeById\n" +
                "5-GetAllEmployeesByDepartmentId\n" + "6-GetAllEmployessByAge\n" + "7-SearchEmployeesWithNameOrSurname\n" +
             "8-GetAllEmployees\n" + "9-GetAllEmployeesByProfession\n" + "10-GetAllEmployeesByAdress\n"
             + "11-GetAllEmployeesByExperienceYear\n" + "12-GetCompanyEmployeesCount\n" + "13-GetAllEmployeesByPension\n"+
             "14-GetAllEmployeesPensionByExperienceYear\n"+ "15-GetEmployeePensionById\n" + "0-Exit\n");
        EnterEMenu: string select = Console.ReadLine();
            bool resultSelect = int.TryParse(select, out int intSelect);
            while (true)
            {
                if (resultSelect && intSelect > 0 && intSelect < 16) 
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
                        case (int)EmployeeSelectionList.GetCompanyEmployeesCount:
                            employeeController.GetEmployeesCount();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployeesByPension:
                            employeeController.GetAllEmployeesByPension();
                            break;
                        case (int)EmployeeSelectionList.GetAllEmployeesPensionByExperienceYear:
                            employeeController.GetAllEmployeesPensionByExperienceYear();
                            break;
                        case (int)EmployeeSelectionList.GetEmployeePensionById:
                            employeeController.GetEmployeePensionById();
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
        StartDMenu: Helper.ChangeTextColor(ConsoleColor.DarkCyan, "A selection list of prosessing methods on departments" +
            "Select the process you want to execute:");
            Helper.ChangeTextColor(ConsoleColor.DarkCyan, "1-CreateDepartment\n" + "2-DeleteDepartment\n" + "3-UpdateDepartment\n" +
                "4-GetDepartmentById\n" +"5-GetAllDepartment\n" + "6-GetDepartmentByName\n" + "7-SearchDepartmentsByCapacity\n" + "0-Exit\n");
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
                                                        + " 1--EmployeeSelectionList\n " + "2--DepartmentSelectionList\n"
                                                        + "0--Exit\n");
        Enter: string selection = Console.ReadLine();
            bool result = int.TryParse(selection, out int intselection);
            while (true)
            {
                if (result && intselection > 0 && intselection < 3)
                {
                       switch (intselection)
                    {
                        case (int)SelectionList.EmployeeSelectionList:
                            EmployeeSelectionListMethod();
                            break;
                        case (int)SelectionList.DepartmentSelectionList:
                            DepartmentSelectionListMethod();
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
