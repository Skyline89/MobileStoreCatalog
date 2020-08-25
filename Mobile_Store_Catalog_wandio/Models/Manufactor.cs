using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Models
{
    public class Manufactor
    {
        [Key]
        public int ManufactorId { get; set; }
        [Required]
        [StringLength(100)]
        public string ManufactorName { get; set; }
        [Required]
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
