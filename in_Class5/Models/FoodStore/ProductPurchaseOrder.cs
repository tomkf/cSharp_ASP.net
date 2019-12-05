﻿using System;
using System.Collections.Generic;

namespace in_Class5.Models.FoodStore
{
    public partial class ProductPurchaseOrder
    {
        public int ProductId { get; set; }
        public int PoNum { get; set; }

        public virtual PurchaseOrder PoNumNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
