using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    
    public class AplicationContext : DbContext
    {
        public AplicationContext (DbContextOptions<AplicationContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC.Models.Movie> Movie { get; set; }

        public DbSet<DemoMVC.Models.Student> Student { get; set; }

        public DbSet<DemoMVC.Models.KhachHang> KhachHang { get; set; }
    }

}
