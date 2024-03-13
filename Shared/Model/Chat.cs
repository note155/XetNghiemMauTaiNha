using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }
        public string data { get; set; }
        public int trangthai { get; set; }  //0 là đã đọc,1 là bác sĩ chưa đọc, 2 là user chưa đọc
        public int? bacsiid { get; set; }
        public int? userid { get; set; }
        public int roomchatid { get; set; }
        public roomchat? Roomchat { get; set; }
        public DateTime thoigian {  get; set; } 
    }
}
