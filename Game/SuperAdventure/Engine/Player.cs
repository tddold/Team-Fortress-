namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player : LivingCreature
    {
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int expiriancePoints, int level)
            : base(currentHitPoints, maximumHitPoints)
        {
            this.Gold = gold;
            this.ExpiriencePoints = expiriancePoints;
            this.Level = level;

            this.Inventory = new List<InventoryItem>();
            this.Quest = new List<PlayerQuest>();
        }

        public int Gold { get; set; }

        public int ExpiriencePoints { get; set; }

        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }

        public List<PlayerQuest> Quest { get; set; }
    }
}
