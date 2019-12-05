using System;
using System.Collections.Generic;

namespace in_Class5.Models.FoodStore
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Product = new HashSet<Product>();
        }

        public string Mfg { get; set; }
        public decimal? MfgDiscount { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
