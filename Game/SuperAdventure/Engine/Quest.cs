﻿namespace Engine
{
    using Engine.Interfaces;
    using System.Collections.Generic;

    public class Quest : IPersonalization ,IPersonalizationExtension , IReward
    {
        //Properties
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RewardExperiencePoints { get; set; }

        public int RewardGold { get; set; }

        public List<QuestCompletionItem> QuestCompletionItems { get; private set; }

        public Item RewardItem { get; set; }

        //Constructor
        public Quest(int id, string name, string description, int rewardExpiriancePoint, int rewardGold)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.RewardExperiencePoints = rewardExpiriancePoint;
            this.RewardGold = rewardGold;
            this.QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
