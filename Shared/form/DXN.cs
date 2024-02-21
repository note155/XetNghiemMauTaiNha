using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.form
{
    public class DXN
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? BacSiId { get; set; }
        public int GoiXetNghiemId { get; set; }
        public DateTime Ngaydat { get; set; }
        public string? ghiChu { get; set; }
        public string Trangthai { get; set; }
        public string giolaymau { get; set; }
        public DateTime ngaytaodon { get; set; }
    }
}
