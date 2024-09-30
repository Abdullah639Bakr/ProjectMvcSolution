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
    public class EmployeeRepository : GenericRepository<Employee> ,IEmployeeRepository
    {

        public EmployeeRepository(MvcProjectContext dbcontext) :base(dbcontext)
        {
        }

       
    }
}
