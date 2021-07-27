using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
    public class Students
    {
        [Required]
        [Key]
        
        public int id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string name { get; set; }
        [Required]
        [Range(10, 100)]
        public int age { get; set; }


        public string img { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public Department Department { get; set; }
    }
}
