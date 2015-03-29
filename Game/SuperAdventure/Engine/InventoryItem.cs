namespace Engine
{
    public class InventoryItem
    {
        public Item Details { get; set; }

        public int Quantity { get; set; }

        public InventoryItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
