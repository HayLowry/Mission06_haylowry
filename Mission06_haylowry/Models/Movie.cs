using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_haylowry.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string cateogry { get; set; }
        public string title { get; set; }
        public byte year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }

    }
}
