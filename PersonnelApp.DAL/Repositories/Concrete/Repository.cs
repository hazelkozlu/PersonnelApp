using PersonnelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //repository class ını diğer repositorylerde miras olarak kullanacağım inin protected DbContext tipinde
        //bir context tanımla
        protected DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(DbContext context)
        {
            //repository classını kullanmak isteyen parametre olarak DbContext nesnesi vermek zorunda
            //burada protected alanına dışarıdan verilen context i atıyoruz
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            //entity framework ün generic olan set methodu kullanılır
            //_context.Departments
            _dbSet.Add(entity);

        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities); 
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList(); 
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            _dbSet.Remove(GetById(id)); 
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);   
        }
    }
}
