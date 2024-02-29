using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class GXNandCS
    {
        [Key]
        public int Id { get; set; }
        public int GoiXetNghiemId { get; set; }
        public GoiXetNghiem? GoiXetNghiem { get; set; }
        public int ChisoId { get; set; }
        public Chiso? Chiso {  get; set; } 
    }
}
