using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataModel
{
    public class Team
    {
        [Key]
        [Required]
        public int IdT { get; set; }
        
        public string NameT { get; set; }
        
        public int IdP { get; set; }
        [ForeignKey("IdP")]
        public  Player player { get; set; }
    }
}
