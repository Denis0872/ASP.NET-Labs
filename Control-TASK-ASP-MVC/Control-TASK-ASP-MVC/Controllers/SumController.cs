using Control_TASK_ASP_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Control_TASK_ASP_MVC.Controllers
{
    public class SumController : Controller
    {
        

        private StudentContext db = new StudentContext();
        // GET: Sum
        public ActionResult Index()
            {
            var totalAmount = 0;
            GetStudents();
            foreach (var item in db.Students)
            {
                totalAmount += item.Mark;
            }

            ViewBag.totalAmount = totalAmount;
            return View();
            }
            private void GetStudents()
            {
                var allStudents = db.Students.ToList<Student>();
                ViewBag.Students = allStudents;
            }
    }
}