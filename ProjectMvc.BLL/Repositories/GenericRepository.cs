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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly MvcProjectContext _dbcontext;

        public GenericRepository(MvcProjectContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Add(T entity)
        {
            _dbcontext.Add(entity);
            return _dbcontext.SaveChanges();
        }

        public int Delete(T entity)
        {
            _dbcontext.Remove(entity);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbcontext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbcontext.Set<T>().Find(id);
        }

        public int Update(T entity)
        {
            _dbcontext.Update(entity);
            return _dbcontext.SaveChanges();
        }
    }
}
