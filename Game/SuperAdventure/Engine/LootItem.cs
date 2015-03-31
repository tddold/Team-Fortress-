namespace Engine
{
    public class LootItem
    {
        //Properties
        public Item Details { get; set; }

        public int DropPercentage { get; set; }

        public bool IsDefaultItem { get; set; }
        //Constructor
        public LootItem(Item details, int dropPrecentage, bool isDefaultItem)
        {
            this.Details = details;
            this.DropPercentage = dropPrecentage;
            this.IsDefaultItem = isDefaultItem;
        }
    }
}
