using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class MayXetNghiem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int phongid { get; set; }
        public Phong? Phong { get; set; }
    }
}
