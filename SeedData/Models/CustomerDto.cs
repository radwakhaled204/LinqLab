using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class CustomerDto
    {
        [Required] 
        public string customerName { get; set; }
        public long customerPhone { get; set; }
    }
}
