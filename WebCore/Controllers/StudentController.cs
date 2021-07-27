using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;
using WebCore.Serves;

namespace WebCore.Controllers
{
    
    
    public class StudentController : Controller
    {
        IStudent st;
        public StudentController(IStudent _st )
        {
            st = _st;
        }
        public IActionResult Index()
        {
            return View(st.GetAllStudent());
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student ss )
        {
            st.AddStudent(ss);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Edit(int id )
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id , Student std )
        {
            st.EditStudent(id,std);
            
            return RedirectToAction("index");
        }


        public IActionResult Delete(int id )
        {
            st.RemoveStudent(id);

            return RedirectToAction("index");
        }


        public IActionResult Details(int id)
        {
            return View(st.GetStudent(id));
        }
    }
}
