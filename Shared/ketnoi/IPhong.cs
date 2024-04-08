using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IPhong
    {
        Task<List<Phong>> getallAsync();
        Task<Phong> addAsync(Phong phong);
        Task<Phong> updateAsync(Phong phong);
        Task<Phong> deleteAsync(int id);
        Task<Phong> getbyid(int Id);
    }
}
