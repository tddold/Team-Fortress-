namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }

        public int DropPercentage { get; set; }

        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropPrecentage, bool isDefaultItem)
        {
            this.Details = details;
            this.DropPercentage = dropPrecentage;
            this.IsDefaultItem = isDefaultItem;
        }
    }
}
