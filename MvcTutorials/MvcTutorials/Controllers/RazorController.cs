using MvcTutorials.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorials.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            var people = new Person[]
            {
                new Person() {Name = "thanh thinh", Age = 23, Email = "thanhthinhcntt@gmail.com", IsSubscribed = true},
                new Person() {Name = "ngoc nhan.", Email = "thanhthinhcntt@gmail.com"},
                new Person() {Name = "thanh truc", Age = 20, IsSubscribed = true},
            };

            return View(people);
        }

        public ActionResult Images()
        {
            return this.View();
        }

        public ActionResult Videos()
        {
            return this.View();
        }

        public ActionResult Table()
        {
            Human[] humans = new Human[]
            {
              new Human() { Id = 1, Name = "Thanh thinh", Age = 20}  ,
              new Human() {Id = 2, Name = "tinh", Age = 22}
            };

            return this.View(humans);
        }
    }
}