

using CompanyApp.Domain.Models;

namespace CompanyApp.Business.Interfaces
{
    public interface IDepartment
    {
        Department Create(Department department, int capacity);
        Department Update(int id, Department department, int capacity);

        Department Delete(int id);
        Department Get(int id);
        List<Department> GetAll();

        List<Department> SearchByCapacity(int capacity);





    }
}
