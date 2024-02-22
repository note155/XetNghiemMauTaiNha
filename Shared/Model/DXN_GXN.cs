using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
	internal class DXN_GXN
	{
		[Key]
		public int Id { get; set; }
		public int DonXetNghiemId { get; set; }
		public DonXetNghiem DonXetNghiem { get; set; }
		public int GoiXetNghiemId { get; set; }
		public GoiXetNghiem? GoiXetNghiem { get; set; }
	}
}
