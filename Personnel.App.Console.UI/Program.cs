using PersonnelApp.DAL;
using PersonnelApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.App.Console.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "Bilgi İşlem",
                IsActive = true,
                CreatedTime = DateTime.Now
            });
            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "ArGe",
                IsActive = true,
                CreatedTime = DateTime.Now
            });
            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "Satınalma",
                IsActive = true,
                CreatedTime = DateTime.Now
            });
            unitOfWork.Complete();




        }
    }
}
