namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Monster : LivingCreature
    {
        public Monster(int id, string name, int maximumDamage, int rewardExpiriancePoints, int rewardGold, int currentHitPoints, int maximumHitPoints)
            : base(currentHitPoints, maximumHitPoints)
        {
            this.ID = id;
            this.Name = name;
            this.MaximumDamage = maximumDamage;
            this.RewardExpiriencePoints = rewardExpiriancePoints;
            this.RewardGold = rewardGold;
            this.LootTable = new List<LootItem>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int MaximumDamage { get; set; }

        public int RewardExpiriencePoints { get; set; }

        public int RewardGold { get; set; }

        public List<LootItem> LootTable { get; set; }
    }
}
