﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string name { get; set; }
        public long telephone { get; set; }
        public int age { get; set; }
        public decimal spendAverage { get; set; }
        public int categoryId { get; set; }
        public bool isActive { get; set; }
        public DateTime joinDate { get; set; }

        public int CompareTo(Customer? other)
        {
            return this.age;
        }
    }
}
