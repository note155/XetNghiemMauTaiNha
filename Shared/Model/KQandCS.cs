using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class KQandCS
    {
        [Key]
        public int Id { get; set; }
        public int KetQuaXetNghiemId { get; set; }
        public KetQuaXetNghiem? KetQuaXetNghiem { get; set; }
        public int ChisoId { get; set; }
        public Chiso? Chiso { get; set; }
        public string KetQua {  get; set; }

    }
}
