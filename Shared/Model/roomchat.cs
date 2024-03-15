using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.Model
{
    public class roomchat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int userid { get; set; }                 
        public User? User { get; set;                                                                                                                                                                               }     
        public int? idbs { get; set; }                                                                                                                                                               

    }
}
