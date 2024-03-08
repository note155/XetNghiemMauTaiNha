using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.form;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface ITuvan
    {
        Task<Tuvan> addAsync(Tuvan tuvan);
        Task<Tuvan> updateAsync(Tuvan tuvan);
        Task<List<Tuvan>> getallAsync();
        Task<gmailTV> guiemail(gmailTV gm);
        Task<Tuvan> getbyidAsync(int id);
    }
}
