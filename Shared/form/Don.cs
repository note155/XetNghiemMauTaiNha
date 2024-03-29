using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.form
{
    public class Don
    {
        public DonXetNghiem? dxn { get; set; }
        public User? nguoi { get; set; }
        public string diachi { get; set; }
        public Boolean chon { get; set; }
    }
}
