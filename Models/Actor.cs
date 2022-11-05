using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Work_with_Interface.Models
{
    public class Actor
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Please enter your full name" )]
        public string FullName { get; set; }
        [DisplayName("Bio")]
        [Required(ErrorMessage ="Please enter your bio")]
        public string Bip { get; set; }
    }
}
