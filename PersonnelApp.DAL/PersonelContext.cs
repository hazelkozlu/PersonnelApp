using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL
{
    public class PersonelContext: DbContext
    {
        //hangi veri tabanona yazacağını bilmesi için connection string veriyoruz.constructorın base class
        // baseclassına connection stringi göndercem
        //conncetion string data access layer projesindeki app.config kısmaına tanımlanır
        public PersonelContext():base("PersonnelContext")
        {

        }
       public  DbSet<Department> Departments { get; set; }
       public DbSet<Personnel> Personnels { get; set; }
    }
}
