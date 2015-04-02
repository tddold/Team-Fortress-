namespace Engine
{
    using Engine.Interfaces;
    using Engine.Exceptions;

    public class InventoryItem : IDetails, IDetailsExtension
    {
        private int quantity;
        
         //Properties
        public Item Details { get; set; }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {

                if (value < 0)
                {
                    throw new QuantityException("Invalid quantity", 0);
                }
                this.quantity = value;
            }
        }

        //Constructor
        public InventoryItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
