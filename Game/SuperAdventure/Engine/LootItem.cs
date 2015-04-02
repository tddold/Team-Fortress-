namespace Engine
{
    using Engine.Interfaces;

    public class LootItem : IDetails
    {
        //Properties
        public Item Details { get; set; }

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
