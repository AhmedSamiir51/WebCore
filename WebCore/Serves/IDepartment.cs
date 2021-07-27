using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Serves
{
    public interface IDepartment
    {
        List<Department> GetAllDepartment();

        Department AddDepartment(Department st);
        Department GetDepartment(int id);

        Department RemoveDepartment(int id);
        Department EditDepartment(int id, Department ss);
    }
}
