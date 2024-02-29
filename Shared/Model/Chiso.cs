using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class Chiso
    {
        [Key]
        public int Id { get; set; }
        
        public string ten {  get; set; }
        public string name { get; set; }

    }
}
