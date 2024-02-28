using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class ThanhToan
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DonXetNghiemId { get; set; }
        public DonXetNghiem? DonXetNghiem { get; set; }
        public long Tongtien {  get; set; }
        public string trangthai { get; set; }
        public DateTime? NgayTT { get; set; }
        public long? DaTT { get; set; }
    }
}
