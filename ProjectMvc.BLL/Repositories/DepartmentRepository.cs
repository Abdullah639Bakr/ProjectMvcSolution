using ProjectMvc.BLL.Interfaces;
using ProjectMvc.DAL.Contexts;
using ProjectMvc.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMvc.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MvcProjectContext _dbcontext;
        public DepartmentRepository(MvcProjectContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Add(Department department)
        {
            _dbcontext.Add(department);
            return _dbcontext.SaveChanges();
        }

        public int Delete(Department department)
        {
            _dbcontext.Remove(department);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbcontext.Departments.ToList();
        }

        public Department GetById(int Id)
        {
            return _dbcontext.Departments.Find(Id);
        }

        public int Update(Department department)
        {
            _dbcontext.Update(department);
            return _dbcontext.SaveChanges();
        }
    }
}
