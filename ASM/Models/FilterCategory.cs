using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Models
{
    public class FilterCategory
    {
        public List<Product> Products { get; set; }
        public SelectList SelectCategory { get; set; }
        public string Category { get; set; }
    }
}
