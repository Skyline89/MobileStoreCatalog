using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Models
{
    public class OperationSystem
    {
        [Key]
        public int OperationSystemId { get; set; }
        [Required]
        [StringLength(100)]
        public string OperationSystemName { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
