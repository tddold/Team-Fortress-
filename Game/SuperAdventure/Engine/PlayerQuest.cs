namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }

        public bool IsCompleted { get; set; }

        public PlayerQuest(Quest details)
        {
            this.Details = details;
            this.IsCompleted = false;
        }
    }
}
