using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Serves
{
    public interface IStudent
    {
        List<Student> GetAllStudent();

        Student AddStudent( Student st);
        Student GetStudent(int id );

        Student RemoveStudent(int id);
        Student EditStudent(int id, Student ss);

    }
}
