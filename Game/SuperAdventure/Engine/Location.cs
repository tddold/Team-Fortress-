namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Location
    {
        public Location(int id, string name, string description,
            Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.ItemRequiredToEnter = itemRequiredToEnter;
            this.QuestAvailableHere = questAvailableHere;
            this.MonsterLivingHere = monsterLivingHere;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Item ItemRequiredToEnter { get; set; }

        public Quest QuestAvailableHere { get; set; }

        public Monster MonsterLivingHere { get; set; }
    }
}
