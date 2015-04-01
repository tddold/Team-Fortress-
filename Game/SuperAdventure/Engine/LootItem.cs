namespace Engine
{
    public class LootItem
    {
        //Properties
        public Item Details { get; private set; }

        public int DropPercentage { get; private set; }

        public bool IsDefaultItem { get; private set; }

        //Constructor
        public LootItem(Item details, int dropPrecentage, bool isDefaultItem)
        {
            this.Details = details;
            this.DropPercentage = dropPrecentage;
            this.IsDefaultItem = isDefaultItem;
        }
    }
}
