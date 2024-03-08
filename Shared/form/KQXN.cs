using System;
using System.Collections.Generic;
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
		public string nhommau { get; set; }
		public string khoa { get; set; }
		public string ghiChu { get; set; }
		public DateTime ngaycoKQ { get; set; }
        public int bsid { get; set; }
        public string maythuchien  { get; set; }
        public List<ChisoKq> kQandCs { get; set; }

	}
}
