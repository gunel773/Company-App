

using CompanyApp.Domain.Models.Common;

namespace CompanyApp.Domain.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int ExperienceYear { get; set; }
        public string Adress { get; set; }
        public string Profession { get; set; }
        public Department Department { get; set; }
    }
}
