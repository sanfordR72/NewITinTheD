using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITintheDWebsite.Models
{
    public class Mentor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public string Info { get; set; }
    }

    
}