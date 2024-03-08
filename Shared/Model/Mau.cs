using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class Mau
    {
        [Key]
        public int Id { get; set; }
        public int DonXetNghiemId { get; set; }
        public DonXetNghiem? DonXetNghiem { get; set; }
        public DateTime ngaynhanmau { get; set; }
        public string khoa { get; set; }
        public int? bacsiid {get;set; }
        public string? phongthuchien { get; set; }
        public string? maythuchien { get; set; }
    }
}
