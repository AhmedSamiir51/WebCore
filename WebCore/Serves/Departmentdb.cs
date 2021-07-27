using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Serves
{
    public class Departmentdb : IDepartment
    {
        private ITIModel _db;

        public Departmentdb(ITIModel db)
        {
            _db = db;
        }
        public Department AddDepartment(Department st)
        {
            _db.Departments.Add(st);
            _db.SaveChanges();
            return st;
        }

        public Department EditDepartment(int id, Department ss)
        {
            var dd = _db.Departments.FirstOrDefault(e => e.Deptid == id);
            dd.DeptName = ss.DeptName;
            _db.SaveChanges();
            return ss;
        }

        public List<Department> GetAllDepartment()
        {
            return _db.Departments.ToList();
        }

        public Department GetDepartment(int id)
        {
            var ss = _db.Departments.Where(e => e.Deptid == id).FirstOrDefault();
            return ss;
        }

        public Department RemoveDepartment(int id)
        {
            var ss = _db.Departments.Where(e => e.Deptid == id).First();
            _db.Departments.Remove(ss);
            _db.SaveChanges();
            return ss;
        }
    }
}
