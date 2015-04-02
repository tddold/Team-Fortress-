namespace Engine
{
    using Engine.Interfaces;

    public class QuestCompletionItem : IDetails , IDetailsExtension
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
