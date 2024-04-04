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
        [Required(ErrorMessage = "Vui lòng cho biết họ tên")]
        public string hoten { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string sdt { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        public string email { get; set; }
        [Required(ErrorMessage = "Nhập nội dung để chúng tôi có thể giúp bạn")]
        public string noidung { get; set; }
        public int? bacsiid { get; set; }
        public string? traloi { get; set; }
        public DateTime? thoigian { get; set; } 
    }
}
