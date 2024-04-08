using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IKhoa
    {
        Task<List<Khoa>> getallAsync();
        Task<Khoa> addAsync(Khoa khoa);
        Task<Khoa> updateAsync(Khoa khoa);
        Task<Khoa> deleteAsync(int id);
        Task<Khoa> getbyid(int Id);
    }
}
