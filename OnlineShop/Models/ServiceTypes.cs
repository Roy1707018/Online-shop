using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ServiceTypes
    {
        [Key]
        public int ServiceId { get; set; }
        [Required]

        [Display(Name = "Service Types")]
        public string ServiceType { get; set; }
    }
}
