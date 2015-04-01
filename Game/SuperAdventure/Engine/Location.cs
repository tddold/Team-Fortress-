namespace Engine
{
    public class Location
    {
        //Properties
        public int ID { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public Item ItemRequiredToEnter { get; private set; }

        public Quest QuestAvailableHere { get; set; }

        public Monster MonsterLivingHere { get; set; }

        public Location LocationToNorth { get; set; }

        public Location LocationToEast { get; set; }

        public Location LocationToSouth { get; set; }

        public Location LocationToWest { get; set; }

        //Constructor
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
    }
}
