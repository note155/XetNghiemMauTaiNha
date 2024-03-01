using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;
using Shared.Model;

namespace Shared.ketnoi
{
	public interface IGioHang
	{
		Task<GioHang> addAsync(GioHang Giohang);
        Task<GioHang> updateAsync(GioHang Giohang);
        Task<GioHang> deleteAsync(int id);
        Task<bool> kiemtra(GioHang Giohang);
        Task<List<GioHang>> getallAsyncbyiduser(int iduser);
        Task<List<GioHang>> getallistrue(int iduser);
    }
}
