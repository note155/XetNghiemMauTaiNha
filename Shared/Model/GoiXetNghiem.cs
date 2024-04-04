using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class GoiXetNghiem
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên gói không được để trống")]
        public string TenGoi { get; set; }
        [Required(ErrorMessage = "Giá không được để trống")]
        public long Gia { get; set; }
        [Required(ErrorMessage = "Thời gian không được để trống")]
        public string ThoiGian { get; set; }
        public string? Mota { get; set; }
        public string? Anh { get; set; }

    }
}
