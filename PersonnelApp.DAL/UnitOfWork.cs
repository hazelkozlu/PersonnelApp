using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        //personelcontext i kullanmak için dışarıdan bir personelcontex nesnesi vermek zorunda
        private PersonelContext _personelContext;
        public UnitOfWork(PersonelContext context)
        {
            _personelContext = context;
            DepartmentRepository = new DepartmentRepository(_personelContext);
            PersonelRepository = new PersonelRepository(_personelContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complete()
        {
            return _personelContext.SaveChanges();
        }

        public void Dispose()
        {
            _personelContext.Dispose(); 
        }
    }
}
