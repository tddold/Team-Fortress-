namespace Engine
{
    public class QuestCompletionItem
    {
        //Properties
        public Item Details { get; private set; }

        public int Quantity { get; private set; }

        //Constructor
        public QuestCompletionItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
