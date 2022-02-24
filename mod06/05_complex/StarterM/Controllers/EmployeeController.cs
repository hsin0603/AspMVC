using Microsoft.AspNetCore.Mvc;
using StarterM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            ViewBag.result = $@"
      Employee id : {emp.EmployeeId}
      Employee Name : {emp.EmployeeName}
      Birth Date : {emp.BirthDate:d}
      CompanyName : {emp.Experience.CompanyName}
      Years : {emp.Experience.Years}
      Interests : {string.Join(",", emp.Interests)}
      ";

            return View();
        }
    }
}
