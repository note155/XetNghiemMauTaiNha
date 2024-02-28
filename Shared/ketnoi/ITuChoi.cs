using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface ITuChoi
    {
        Task<TuChoi> addAsync(TuChoi tuchoi);
        Task<List<TuChoi>> getallAsync();
        Task<TuChoi> getbyidAsync(int iddon);
    }
}
