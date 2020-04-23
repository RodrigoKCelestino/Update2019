using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> deps = new List<Department>();
            deps.Add(new Department { Id = 1, Name = "Eletronics" });
            deps.Add(new Department { Id = 2, Name = "Fashiom" });

            return View(deps);
        }
    }
}