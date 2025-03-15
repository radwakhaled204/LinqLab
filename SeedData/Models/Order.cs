using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace SeedData.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        public decimal total { get; set; }
        [Required(ErrorMessage = "Enter The Date")]
        public DateTime orderDate { get; set; }
        [ForeignKey(nameof(Order))]
        public int customerId { get; set; }
    }
}
