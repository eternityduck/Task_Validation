using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ProductsValidation.Models
{
    
    public class Product
    {
        public enum Category { Toy, Technique, Clothes, Transport}

        public int Id { get; set; }
        public Category Type { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(1000, MinimumLength = 2)]
        [Description]
        public string Description { get; set; }
        [Range(0, 100000)]
        public decimal Price { get; set; }
    }
}
