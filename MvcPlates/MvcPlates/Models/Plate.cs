using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlates.Models
{
    public class Plate
    {
        public string Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Size(in Inches)")]
        public int Size { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public int Rating { get; set; }
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Modified Date")]
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }
    }
}
