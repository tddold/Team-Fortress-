namespace Engine
{
    public class InventoryItem
    {
        //Properties
        public Item Details { get; private set; }

        public int Quantity { get; set; }

        //Constructor
        public InventoryItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
