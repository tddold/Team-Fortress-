namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlayerQuest
    {
        public PlayerQuest(Quest details)
        {
            this.Details = details;
            this.IsCompleted = false;
        }

        public Quest Details { get; set; }

        public bool IsCompleted { get; set; }
    }
}
