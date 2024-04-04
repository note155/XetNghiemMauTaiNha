using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class BacSi
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string Hoten { get; set; }
        [Required(ErrorMessage = "Chức vụ không được để trống")]
        public string Chucvu { get; set; }
        public string? Anh { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }
        public string? trangthai { get; set; } 
        public int? Sonamkn { get; set; }
        public string? Chuyenkhoa { get; set; }
        public string? Trinhdo { get; set; }
        public string? Thongtin { get; set; }


    }
}
