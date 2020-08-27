using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Models
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        public int ManufactorId { get; set; }
        public int OperationSystemId { get; set; }
        [Required]
        [ForeignKey("ManufactorId")]
        public Manufactor Manufactor { get; set; }
        [Required]
        [ForeignKey("OperationSystemId")]
        public OperationSystem OperationSystem { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneName { get; set; }
        [Required]
        public double Size { get; set; }
        [Required]
        public double Wight { get; set; }
        [Required]
        [StringLength(100)]
        public string ScreenResolution { get; set; }
        [Required]
        [StringLength(100)]
        public string Processor { get; set; }
        [Required]
        public string Memory { get; set; }
        [Required]
        [StringLength(255)]
        public string VideoPath { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
