using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IMayXetNghiem
    {
        Task<List<MayXetNghiem>> getallAsync();
        Task<MayXetNghiem> addAsync(MayXetNghiem may);
        Task<MayXetNghiem> updateAsync(MayXetNghiem may);
        Task<MayXetNghiem> deleteAsync(int id);
        Task<MayXetNghiem> getbyid(int Id);
    }
}
