using MvcApplication4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student()
                {
                    ID = 5601,
                    Name = "Name A"
                });
            
            students.Add(new Student()
            {
                ID = 5602,
                Name = "Name B"
            });

            students.Add(new Student()
            {
                ID = 5603,
                Name = "Name C"
            });

            return View(students.ToArray());
        }

    }
}
