using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
    public class Department
    {
        [Key]
        public int Deptid { get; set; }
        public string DeptName { get; set; }

        public List<Students> Students { get; set; }

    }
}
