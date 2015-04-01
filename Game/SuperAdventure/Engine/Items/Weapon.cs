namespace Engine
{
    public class Weapon : Item
    {
        //Properties
        public int MinimumDamage { get; private set; }

        public int MaximumDamage { get; private set; }

        //Constructors
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage)
            : base(id, name, namePlural)
        {
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
        }
    }
}
