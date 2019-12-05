using System;
using System.Collections.Generic;

namespace in_Class5.Models.FoodStore
{
    public partial class Building
    {
        public Building()
        {
            Store = new HashSet<Store>();
        }

        public string BuildingName { get; set; }
        public int UnitNum { get; set; }
        public int? Capacity { get; set; }

        public virtual ICollection<Store> Store { get; set; }
    }
}
