using System;
using System.Collections.Generic;

namespace in_Class5.Models.FoodStore
{
    public partial class ProductInvoice
    {
        public int ProductId { get; set; }
        public int InvoiceNum { get; set; }

        public virtual Invoice InvoiceNumNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
