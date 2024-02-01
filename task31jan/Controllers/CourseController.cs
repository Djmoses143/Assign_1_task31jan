using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task31jan.Models;

namespace task31jan.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course(){Id=1,Name="MI/AL",Fee=42000,Technology="Machine Learning",CStartDate=new DateTime(day:12,month:01,year:2022),CEndDate=new DateTime(day:02,month:08,year:2023)},
            new Course(){Id=2,Name="MI/AL",Fee=54000,Technology="Artificial Intelligence",CStartDate=new DateTime(day:12,month:01,year:2022),CEndDate=new DateTime(day:02,month:08,year:2023)},
            new Course(){Id=3,Name="Jave FSD",Fee=32000,Technology="Java",CStartDate=new DateTime(day:12,month:01,year:2022),CEndDate=new DateTime(day:02,month:08,year:2023)},
            new Course(){Id=4,Name="Python FSD",Fee=36000,Technology="Python",CStartDate=new DateTime(day:12,month:01,year:2022),CEndDate=new DateTime(day:02,month:08,year:2023)},

        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course c)
        {
            if(ModelState.IsValid)
            {
                courses.Add(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }
    }
}