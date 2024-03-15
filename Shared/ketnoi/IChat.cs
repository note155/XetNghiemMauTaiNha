using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IChat
    {
        Task<Chat> addAsync(Chat chat);
        Task<List<Chat>> getallbyidroomAsync(int id);
		Task<Chat> updateAsync(Chat chat);
	}
}
