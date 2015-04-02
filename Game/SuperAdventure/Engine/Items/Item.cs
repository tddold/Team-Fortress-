namespace Engine
{
    using Engine.Interfaces;
    public class Item : IPersonalization
    {
        //Properties
        public int ID { get; set; }

        public string Name { get; set; }

        public string NamePlural { get; private set; }

        //Constructor
        public Item(int id, string name, string namePlural)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePlural;
        }
    }
}
