using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Serves
{
    public class Studentdb:IStudent
    {
        List<Student> std = new List<Student>()
        {
            new Student(){ id=1,name="ahmed",age=20},
            new Student(){ id=2,name="mohamed",age=22},
            new Student(){ id=3,name="Abbas",age=23},
            new Student(){ id=4,name="alaa",age=24},
            new Student(){ id=5,name="emad",age=25}
        };


        public List<Student> GetAllStudent()
        {
            return std;
        }

        public Student AddStudent(Student st)
        {
            std.Add(st);
            return st;
        }

        public Student EditStudent(int id ,Student ss)
        {
            var dd = std.FirstOrDefault(e => e.id == id);
            dd.name= ss.name;
            dd.age = ss.age;


            return ss;
        }

        public Student GetStudent(int id)
        {
            var ss=std.Where(e => e.id == id).FirstOrDefault();
            return ss ;
        }

        public Student RemoveStudent(int id )
        {
            var ss=std.Where(e=>e.id==id).First();
            std.Remove(ss);
            return ss ;
        }
    }
}
