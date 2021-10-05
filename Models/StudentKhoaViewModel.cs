using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DemoMVC.Models
{
    public class StudentKhoaViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Khoas { get; set; }
        public string StudentKhoa { get; set; }
        public string SearchString { get; set; }
    }
}