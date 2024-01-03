using CompanyApp.Domain.Models.Common;


namespace CompanyApp.Domain.Models
{
    public class Department : BaseEntity
    {
        public int Capacity { get; set; }
        public string Name { get; set; }

        public string DepartmentName { get; set; }
       
 

    }

}
