using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Domain
{
    public class Department:BaseEntity
    {

        //ICollection şeklinde olduğu için ilerde nullreferances exception hatası almamak için
        //constroctor tanımlıyoruz ICollection listesini hafızaya çıkartmamız gerekiyor.
        public Department()
        {
                Personnels = new List<Personnel>();
        }

        //bu sınıfta baseentityden miras alınmıştır
        public int Id { get; set; }
        public string Name { get; set; }
        //bir departmanda birden çok personel olabilir
        public ICollection<Personnel> Personnels { get; set; }
    }
}
