using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Students.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Students.Data.Interfaces;

namespace Students.Controllers
{
    public class StudContController : Controller
    {
        private IStudCont cont;

        public StudContController(IStudCont cont)
        {
            this.cont = cont;
        }

        public ViewResult List()
        {
            cont = new StudCont();
            cont.Add(new Student("Luhoviy Oleksander Evgeniyovich", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 95));
            cont.Add(new Student("Orlova Vlada Stanislavovna", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 94));
            cont.Add(new Student("Myhlin Andrew Aleksandrovich", new DateTime(2002, 3, 31), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 67));
            return View(cont.toList());
        }
    }
}
