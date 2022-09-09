using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Domain
{
    public class Personnel:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //departman tablosu ile foreign key 
        public int DepartmantId { get; set; }
        //navigation property her personel bir departmana dahil
        public Department Department { get; set; }
    }
}
