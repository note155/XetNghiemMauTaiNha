using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class Tinhtrang
    {
        [Key]
        public int Id { get; set; }
        public int DonXetNghiemId { get; set; }
        public DonXetNghiem? DonXetNghiem { get; set; }
        public string trangthai { get; set; }
        public DateTime thoigian {  get; set; }
    }
}
