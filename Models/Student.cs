using System;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoMVC.Data;
using DemoMVC.Models;

namespace DemoMVC.Models
{
    public class Student

    {
        
          [Key]
          public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
         [Required]
        public string Hoten{ get; set; }
        public int Masinhvien{ get; set; }
        public string Lop { get; set; }
        public string Khoa{ get; set; }
    }
}