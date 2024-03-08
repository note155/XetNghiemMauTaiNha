using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IMau
    {
        Task<Mau> addAsync(Mau mau);
        Task<List<Mau>> getallAsync();
        Task<Mau> getbyid(int Id);
        Task<Mau> updateAsync(Mau mau);
    }
}
