using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginSecure.Models
{
    public enum Gioitinh
    {
        Nam,
        Nu
    }
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Gioitinh GioitinhNV { get; set; }
    }
}