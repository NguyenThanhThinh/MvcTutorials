using MvcTutorials.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorials.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var data = new List<Employee>();
            data.Add(new Employee() { Id = 1, Name = "Peter" });
            data.Add(new Employee() { Id = 2, Name = "John" });
            data.Add(new Employee() { Id = 3, Name = "Mary" });
            data.Add(new Employee() { Id = 4, Name = "Paul" });

            return View(data);
        }
    }
}