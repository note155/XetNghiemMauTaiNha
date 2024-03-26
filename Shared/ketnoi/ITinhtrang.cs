using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface ITinhtrang
    {
        Task<Tinhtrang> addAsync(Tinhtrang tinhtrang);
        Task<List<Tinhtrang>> getbyidAsync(int iddon);
    }
}
