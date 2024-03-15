using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IRoomchat
    {
        Task<roomchat> addAsync(roomchat roomchat);
        Task<roomchat> updateAsync(roomchat roomchat);
        Task<List<roomchat>> getallbyidAsync(int id);
        Task<roomchat> getbyidAsync(int id);
		Task<List<roomchat>> getallAsync();

	}
}
