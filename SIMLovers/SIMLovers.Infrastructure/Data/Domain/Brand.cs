﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMLovers.Infrastructure.Data.Domain
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string BrandName { get; set; } = null!;

        public virtual IEnumerable<Product> products { get; set; } = new List<Product>();
    }
}
