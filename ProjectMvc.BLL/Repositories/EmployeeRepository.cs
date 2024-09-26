using Microsoft.EntityFrameworkCore;
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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MvcProjectContext _dbcontext;

        public EmployeeRepository(MvcProjectContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public int Add(Employee employee)
        {
            _dbcontext.Employees.Add(employee);
            return _dbcontext.SaveChanges();
        }

        public int Delete(Employee employee)
        {
            _dbcontext.Remove(employee);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dbcontext.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _dbcontext.Employees.Find(id);
        }

        public int Update(Employee employee)
        {
            _dbcontext.Update(employee);
            return _dbcontext.SaveChanges();
        }
    }
}
