using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Họ tên không được để trống")]
        public string Hoten { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Diachi { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn Quận/Huyện")]
        public string? CapHuyen { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn Phường/Xã")]
        public string? CapXa { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public bool Gioitinh { get; set; }
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime Ngaysinh {  get; set; }
        public string? Quanhe {  get; set; }
    }
}
