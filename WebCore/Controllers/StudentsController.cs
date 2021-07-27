using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;
using WebCore.Serves;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebCore.Controllers
{
    public class StudentsController : Controller
    {
        private IStudents _db;
        private IDepartment _dept;
        private readonly IHostingEnvironment Environment;
        public StudentsController(IStudents db , IDepartment dept , IHostingEnvironment _environment)
        {
            _db = db;
            _dept = dept;
            this.Environment = _environment;
        }
        public IActionResult Index()
        {
            ViewBag.dept = new SelectList(_dept.GetAllDepartment(), "Deptid", "DeptName");
            return View(_db.GetAllStudent());
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.dept = new SelectList(_dept.GetAllDepartment(), "Deptid", "DeptName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Students ss,IFormFile img )
        {
            _db.AddStudent(ss,img);
            return RedirectToAction("index");
        }


        public IActionResult Details(int id)
        {
            ViewBag.dept = new SelectList(_dept.GetAllDepartment(), "Deptid", "DeptName");

            return View(_db.GetStudent(id));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
           Students st= _db.GetStudent(id);
            ViewBag.dept = new SelectList(_dept.GetAllDepartment(), "Deptid", "DeptName");
            return View(st);
        }
        [HttpPost]
        public IActionResult Edit(int id,Students st, IFormFile img)
        {
            _db.GetAllStudent();
            _db.EditStudent(id, st, img);
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            _db.RemoveStudent(id);
            return RedirectToAction("index");
        }


    }
}
