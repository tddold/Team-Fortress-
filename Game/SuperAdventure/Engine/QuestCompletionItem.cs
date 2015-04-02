namespace Engine
{
    using Engine.Interfaces;

    public class QuestCompletionItem : IDetails
    {
        //Properties
        public Item Details { get; set; }

        public int Quantity { get; private set; }

        //Constructor
        public QuestCompletionItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
