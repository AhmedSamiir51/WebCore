using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;
using WebCore.Serves;

namespace WebCore.Controllers
{
    public class DepartmentsController : Controller
    {
        private IDepartment _db;

        public DepartmentsController(IDepartment db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.GetAllDepartment());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department ss)
        {
            _db.AddDepartment(ss);
            return RedirectToAction("index");
        }

        public IActionResult Details(int id)
        {
            return View(_db.GetDepartment(id));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_db.GetDepartment(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Department st)
        {
            _db.EditDepartment(id, st);
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            _db.RemoveDepartment(id);
            return RedirectToAction("index");
        }




    }
}
