using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class Tuvan
    {
        [Key]
        public int id { get; set; }
        public string hoten { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string noidung { get; set; }
        public int? bacsiid { get; set; }
        public string? traloi { get; set; }
        public DateTime? thoigian { get; set; } 
    }
}
