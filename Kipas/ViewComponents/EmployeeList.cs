using Kipas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Kipas.ViewComponents
{
    public class EmployeeList : ViewComponent
    {
        KipasDbContext db = new KipasDbContext();
        public IViewComponentResult Invoke()
        {

            var employees = (from a in db.Employee.ToList()
                             join b in db.State.ToList() on a.StateId equals b.Id
                             select new Employee
                             {
                                 StateId = b.Id,
                                 State =new State { Id=b.Id,Name=b.Name},
                                 BirthDate = a.BirthDate,
                                 HireDate = a.HireDate,
                                 FirstName = a.FirstName,
                                 LastName = a.LastName,
                                 Id = a.Id,
                                 Notes = a.Notes,
                                 Title= a.Title,
                                 Address=a.Address,
                                 Position = a.Position,

                             }).ToList();


            return View(employees);
        }
    }
}
