namespace Engine
{
    public class Item
    {
        //Properties
        public int ID { get; private set; }

        public string Name { get; private set; }

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
