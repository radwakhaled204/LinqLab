using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class CustomerDto
    {
        [Required(ErrorMessage = "Please Enter the name")] 
        public string customerName { get; set; }
        [Column("Phone")]
        public long customerPhone { get; set; }
    }
}
