using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public Phone PhoneId { get; set; }
        public string PhotoPath { get; set; }
    }
}
