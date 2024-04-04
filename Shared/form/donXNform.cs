using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.form
{
    public class donXNform
    {
        public string? Hoten { get; set; }
        public string? Diachi { get; set; }
        public string? Email { get; set; }
        public string? SDT { get; set; }
        public bool Gioitinh { get; set; }
        public int Tuoi { get; set; }
        public int idgoixetnghiem {  get; set; }
        [NgayDatValidation(ErrorMessage = "Ngày đặt phải là ngày hiện tại hoặc tương lai")]
        public DateTime Ngaydat { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn giờ lấy mẫu")]
        public string giolaymau { get; set; }
        public string ghiChu { get; set; }

    }
    public class NgayDatValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ngayDat = (DateTime)value;

            // Kiểm tra nếu ngày đặt lớn hơn hoặc bằng ngày hiện tại
            if (ngayDat.Date >= DateTime.Now.Date)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}
