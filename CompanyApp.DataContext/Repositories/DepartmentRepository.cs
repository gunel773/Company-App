using CompanyApp.DataContext.Interfaces;
using CompanyApp.Domain.Models;


namespace CompanyApp.DataContext.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        public bool Create(Department entity)
        {
            try
            {
                DbContext.Departments.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Department entity)
        {
            try
            {
                DbContext.Departments.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Department Get(Predicate<Department> filter)
        {
            return DbContext.Departments.Find(filter);

        }

        public List<Department> GetAll(Predicate<Department> filter = null)
        {
            return filter == null ? DbContext.Departments : DbContext.Departments.FindAll(filter);
        }



        public List<Department> Search(Predicate<Department> filter = null)
        {
            return filter==null ? DbContext.Departments :DbContext.Departments.FindAll(filter);
        }

        public bool Update(Department entity)
        {
            try
            {
                var existDepartment = Get(d => d.Id == entity.Id);
                existDepartment = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
