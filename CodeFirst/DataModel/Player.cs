using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataModel
{
     public class Player
     {
        [Key] public int IdP { get; set; }
        [Required]
        [MaxLength(100)]
        public string NameP { get; set; }
        public int Number { get; set; }
        public Pos pos { get; set; }
        public string Country { get; set; }

       
     }
     public enum Pos
     {
        Striker,
        Midfielder,
        Defender,
        Goalkeeper
     }

}
