using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class CodeFirstController : Controller
    {
        CodeFirstContext db = new CodeFirstContext();
        // GET: CodeFirst
        public ActionResult Demo()
        {
            db.StudentsTable.ToList();
            db.DepartmentsTable.ToList();
            return View();
        }
    }
}