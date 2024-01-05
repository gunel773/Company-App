
namespace CompanyApp.Utilities
{
    public class Helper
    {
         
        public static void ChangeTextColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        public enum SelectionList
        {
           
            EmployeeSelectionList=1,
            DepartmentSelectionList
           

        }
        public enum EmployeeSelectionList  //A selection list of operating methods on employees
        {
            CreateEmployee=1,
            DeleteEmployee,
            UpdateEmployee,
            GetEmployeeById,
            GetAllEmployeesByDepartmentId,
            GetAllEmployessByAge,
            SearchEmployeesWithNameOrSurname,
            GetAllEmployees,
            GetAllEmployeesByProfession,
            GetAllEmployeesByAdress,
            GetAllEmployeesByExperienceYear,
            GetCompanyEmployeesCount,
            GetAllEmployeesByPension,
            GetAllEmployeesPensionByExperienceYear,
            GetEmployeePensionById

        }
        public enum DepartmentSelectionList  //A selection list of operating methods on departments
        {
            CreateDepartment=1,
            DeleteDepartment,
            UpdateDepartment,
            GetDepartmentById,
            GetAllDepartment,
            GetDepartmentByName,
            SearchDepartmentsByCapacity
        }

    }
}
