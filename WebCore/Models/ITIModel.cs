using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
    public class ITIModel :DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public ITIModel(DbContextOptions<ITIModel> options):base(options)
        {

        }
    }
}
