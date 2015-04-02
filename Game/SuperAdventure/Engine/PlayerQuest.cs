namespace Engine
{
    using Engine.Interfaces;

    public class PlayerQuest 
    {
        //Properties
        public Quest Details { get; set; }

        public bool IsCompleted { get; set; }

        //Constructor
        public PlayerQuest(Quest details)
        {
            this.Details = details;
            this.IsCompleted = false;
        }
    }
}
