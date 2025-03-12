using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        [Required]
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal Quntitiy { get; set; }
    }
}
