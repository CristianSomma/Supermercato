using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public class ProductOptions
    {
        public string Name { get; set; }
        public string? Brand { get; set; }
        public ProductCategory Category { get; set; }
        public float Price { get; set; }
        public uint DiscountPercentage { get; set; }
        public uint Stock { get; set; }
    }
}
