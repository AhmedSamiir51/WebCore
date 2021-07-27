using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Serves
{
    public interface IStudents
    {
        List<Students> GetAllStudent();

        Students AddStudent(Students st , IFormFile d);
        Students GetStudent(int id);
        Students RemoveStudent(int id);
        Students EditStudent(int id, Students ss,IFormFile d);

    }
}
