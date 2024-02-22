using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
	public class GioHang
	{
		[Key]
		public int Id { get; set; }
		public int UserId { get; set; }
		public User? User { get; set; }
		public int GoiXetNghiemId { get; set; }
		public GoiXetNghiem? GoiXetNghiem { get; set; }
		
	}
}
