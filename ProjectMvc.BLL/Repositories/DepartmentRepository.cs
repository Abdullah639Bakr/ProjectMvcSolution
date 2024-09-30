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
    public class DepartmentRepository : GenericRepository<Department> ,IDepartmentRepository
    {
        public DepartmentRepository(MvcProjectContext dbcontext) :base(dbcontext) 
        {
        }
       
    }
}
