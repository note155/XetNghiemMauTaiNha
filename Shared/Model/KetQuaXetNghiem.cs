using System.ComponentModel.DataAnnotations;
using Shared.Model;

namespace duanxetnghiem.Data.Model
{
    public class KetQuaXetNghiem
    {
        [Key]
        public int Id { get; set; }
        public int DonXetNghiemId { get; set; }
        public DonXetNghiem? DonXetNghiem { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nhóm máu")]
        public string nhommau { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn khoa")]
        public int khoaId { get; set; }
        public string? ghiChu { get; set; }
        public DateTime ngaycoKQ { get; set; }
    }
}
