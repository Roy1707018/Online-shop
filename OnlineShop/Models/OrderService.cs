using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace OnlineShop.Models
{
    public class OrderService
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int Phonenumber { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        [Display(Name = "Service Type")]
        public int ServiceTypeId { get; set; }
        [ForeignKey("ServiceTypeId")]
        public virtual ServiceTypes ServiceTypes { get; set; }

    }
}
