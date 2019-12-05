using System;
using System.Collections.Generic;

namespace in_Class5.Models.FoodStore
{
    public partial class ProductInvoiceWithQuantity
    {
        public int ProductId { get; set; }
        public int InvoiceNum { get; set; }
        public int? Quantity { get; set; }

        public virtual Invoice InvoiceNumNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
