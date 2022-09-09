using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Domain
{
    public class BaseEntity
    {
        //bu 4 alan tüm etitylerde ortak olacak
        public DateTime? CreatedTime { get; set; } 
        public DateTime? UpdatedTime { get; set; } 
        public DateTime? DeletedTime { get; set; } 
        public bool  IsActive { get; set; } 
    }
}
