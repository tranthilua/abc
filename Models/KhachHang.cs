using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }
        public int MaNV {get;set; }
        public string TenNV {get;set; }
        public string TenPhong {get;set; }
        public int SDT {get;set; }
        public string GioiTinh{get;set;}
    }
}