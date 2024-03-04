using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.form
{
    public class GXNchon
    {
        public int Id { get; set; }
        public string TenGoi { get; set; }
        public long Gia { get; set; }
        public string ThoiGian { get; set; }
        public string? Mota { get; set; }
        public string? Anh { get; set; }
        public bool? IsSelected { get; set; }
    }
}
