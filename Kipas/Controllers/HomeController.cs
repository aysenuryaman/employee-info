using Kipas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kipas.Controllers
{
    public class HomeController : Controller
    {
        KipasDbContext db = new KipasDbContext();
        void StateDropList()
        {
            List<SelectListItem> ıtems = (from i in db.State.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Name,
                                              Value = i.Id.ToString()
                                          }).ToList();
            ViewBag.state = ıtems;
        }
        [HttpGet]
        public IActionResult Index()
        {
            StateDropList();

            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employees)
        {
            Employee employee = new Employee();

            if (!ModelState.IsValid)
            {
                return NoContent();
            }


            employee.FirstName = employees.FirstName;
            employee.LastName = employees.LastName;
            employee.Title = employees.Title;
            employee.Notes = employees.Notes;
            employee.Address = employees.Address;
            employee.BirthDate = employees.BirthDate;
            employee.HireDate = employees.HireDate;
            employee.StateId = employees.StateId;
            employee.Position = employees.Position;


            db.Employee.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
          
        }
        [HttpPost]
        public IActionResult Update(Employee employees)
        {
            var employee = db.Employee.FirstOrDefault(x=>x.Id==employees.Id);
            if (!ModelState.IsValid)
            {
                return NoContent();
            }
            employee.FirstName = employees.FirstName;
            employee.LastName = employees.LastName;
            employee.Title = employees.Title;
            employee.Notes = employees.Notes;
            employee.Address = employees.Address;
            employee.BirthDate = employees.BirthDate;
            employee.HireDate = employees.HireDate;
            employee.StateId = employees.StateId;
            employee.Position = employees.Position; 
            db.Employee.Update(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
