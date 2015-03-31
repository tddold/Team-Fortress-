namespace Engine
{
    public class InventoryItem
    {
        //Properties
        public Item Details { get; set; }

        public int Quantity { get; set; }

        //Constructor
        public InventoryItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
