using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class Customer : IComparable<Customer>
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(20) ]
        public string name { get; set; }
        [Column("phone")]
        public long telephone { get; set; }
      
        public int age { get; set; }
        public decimal spendAverage { get; set; }
        public int categoryId { get; set; }
        public bool isActive { get; set; }
        public DateTime joinDate { get; set; }
        //comerison
        public int CompareTo(Customer? other)
        {
            return this.age;
        }
    }
}
