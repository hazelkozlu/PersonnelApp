using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class PersonelRepository : Repository<Personnel>, IPersonelRepository
    {
        public PersonelRepository(PersonelContext context):base(context)
        {

        }
        public IEnumerable<Personnel> GetPersonnelsWithDepartments()
        {
            return PersonelContext.Personnels.Include("Department").ToList();
        }
        PersonelContext PersonelContext { get { return _context as PersonelContext; } }   
    }
}
