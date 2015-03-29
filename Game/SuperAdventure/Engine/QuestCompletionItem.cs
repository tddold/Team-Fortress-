namespace Engine
{
    public class QuestCompletionItem
    {
        public Item Details { get; set; }

        public int Quantity { get; set; }

        public QuestCompletionItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
