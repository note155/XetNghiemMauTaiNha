using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IThanhToan
    {
        Task<ThanhToan> addAsync(ThanhToan thanhToan);
        Task<List<ThanhToan>> getallAsync(int id);
        Task<ThanhToan> updateAsync(ThanhToan thanhToan);
        Task<ThanhToan> deleteAsync(int id);
    }
}
