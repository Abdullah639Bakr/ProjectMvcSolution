using Microsoft.EntityFrameworkCore;
using ProjectMvc.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMvc.DAL.Contexts
{
    public class MvcProjectContext:DbContext
    {
        public MvcProjectContext(DbContextOptions<MvcProjectContext>options):base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = .; Database = MvcProject; Trusted_Connection = true; TrustServerCertificate = true;");
        //}

        public DbSet<Department> Departments { get; set; }
    }
}
