using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Models
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        public Manufactor ManufactorId { get; set; }
        public OperatingSystem OperationSystemId { get; set; }
        public string PhoneName { get; set; }
        public double Size { get; set; }
        public double Wight { get; set; }
        public string ScreenResolution { get; set; }
        public string Processor { get; set; }
        public int Memory { get; set; }
        public string VideoPath { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
