using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class Khoa
    {
        [Key]
        public int Id { get; set; }
        public string ten { get; set; }
    }
}
