using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class CustomerCategory
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter The Name")]
        public string Name { get; set; }
        public IEnumerable<Customer>? customer { get; set; }
    }
}
