﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TechTrends.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Brand { get; set; }

        [MaxLength(100)]
        public string Category { get; set; }

        [Precision(16,2)]
        public decimal Price { get; set; }
        public string Description { get; set; }

        [MaxLength(100)]
        public String ImageFileName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
