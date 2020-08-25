using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public int PhoneId { get; set; }
        [Required]
        [ForeignKey("PhoneId")]
        public Phone Phone { get; set; }
        [StringLength(255)]
        [Required]
        public string PhotoPath { get; set; }
    }
}
