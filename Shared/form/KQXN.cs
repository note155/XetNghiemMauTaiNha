using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;
using Shared.Model;

namespace Shared.form
{
	public class KQXN
	{
		public int DonXetNghiemId { get; set; }
        [Required(ErrorMessage = "Nhóm máu không được để trống")]
        public string nhommau { get; set; }
        public int khoa { get; set; }
		public string ghiChu { get; set; }
		public DateTime ngaycoKQ { get; set; }
        public int bsid { get; set; }
        public int maythuchien  { get; set; }
        public List<ChisoKq> kQandCs { get; set; }

	}
}
