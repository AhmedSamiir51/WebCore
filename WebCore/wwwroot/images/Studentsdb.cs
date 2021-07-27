using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Serves
{
    public class Studentsdb : IStudents
    {
        private ITIModel _db;
        private readonly IHostingEnvironment Environment;

        public Studentsdb(ITIModel db, IHostingEnvironment _environment)
        {
            _db = db;
            this.Environment = _environment;

        }

        public Students AddStudent(Students st, IFormFile s)
        {
            _db.Students.Add(st);
            _db.SaveChanges();
            return st;
        }

        public Students EditStudent(int id, Students ss, IFormFile s )
        {
            string[] arr = s.FileName.Split('.');
            string myimg = ss.id + "." + arr[arr.Length - 1];
            string uploaded = Path.Combine(Environment.WebRootPath, "images");
            string filpath = Path.Combine(uploaded, myimg);
            s.CopyTo(new FileStream(filpath, FileMode.Create));
            ss.img = myimg;

            var dd = _db.Students.FirstOrDefault(e => e.id == id);
            dd.name = ss.name;
            dd.age = ss.age;
            dd.img = s.FileName;
            dd.DeptId = ss.DeptId;
            _db.SaveChanges();
            return ss;
        }

        public List<Students> GetAllStudent()
        {
            return _db.Students.ToList();
        }

        public Students GetStudent(int id)
        {
            var ss = _db.Students.Where(e => e.id == id).FirstOrDefault();

            return ss;
        }

        public Students RemoveStudent(int id)
        {
            var ss = _db.Students.Where(e => e.id == id).First();
            _db.Students.Remove(ss);
            _db.SaveChanges();
            return ss;
        }
    }
}
