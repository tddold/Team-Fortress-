namespace Engine
{
    using System.Collections.Generic;

    public class Monster : LivingCreature
    {
        //Properties
        public int ID { get; set; }

        public string Name { get; set; }

        public int MaximumDamage { get; set; }

        public int RewardExperiencePoints { get; set; }

        public int RewardGold { get; set; }

        public List<LootItem> LootTable { get; set; }

        //Constructor
        public Monster(int id, string name, int maximumDamage, int rewardExpiriancePoints, int rewardGold, int currentHitPoints, int maximumHitPoints)
            : base(currentHitPoints, maximumHitPoints)
        {
            this.ID = id;
            this.Name = name;
            this.MaximumDamage = maximumDamage;
            this.RewardExperiencePoints = rewardExpiriancePoints;
            this.RewardGold = rewardGold;
            this.LootTable = new List<LootItem>();
        }
    }
}
