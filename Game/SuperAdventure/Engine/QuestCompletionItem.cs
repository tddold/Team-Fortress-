namespace Engine
{
    public class QuestCompletionItem
    {
        //Properties
        public Item Details { get; set; }

        public int Quantity { get; set; }
        //Constructor
        public QuestCompletionItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
