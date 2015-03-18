namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LootItem
    {
        public LootItem(Item details, int dropPrecentage, bool isDefaultItem)
        {
            this.Details = details;
            this.DropPercentage = dropPrecentage;
            this.IsDefaultItem = isDefaultItem;
        }

        public Item Details { get; set; }

        public int DropPercentage { get; set; }

        public bool IsDefaultItem { get; set; }
    }
}
