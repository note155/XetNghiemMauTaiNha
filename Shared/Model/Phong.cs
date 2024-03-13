using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class Phong
    {
        [Key]
        public int Id { get; set; }
        public string maphong { get; set; }
        public string ten { get; set; }
        public int Khoaid { get; set; }
        public Khoa? khoa{ get; set; }
    }
}
