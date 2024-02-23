using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.form
{
    public class giohangtam
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GoiXetNghiemId { get; set; }
        public bool? IsSelected { get; set; }
        public string? TenGoiXetNghiem { get; set; }
        public long? Gia { get; set; }
        public string? ThoiGian { get; set; }
        // Add this property
    }
}
