
using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        //bu projedeki her personelcontext bir dbcontexttir
        public DepartmentRepository(PersonelContext context):base(context)
        {

            
        }
       
        public IEnumerable<Department> GetDepartmentsWithPersonnels()
        {
            return PersonelContext.Departments.Include("Personels").ToList();
            
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonelContext.Departments.Take(count);
        }

        //cast işlemi _context için yapıtoruz
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
