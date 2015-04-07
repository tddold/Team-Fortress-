namespace Engine
{
    using Engine.Interfaces;

    public class Weapon : Item , IMaximumDamage , IMinimumDamage
    {
        //Properties
        public int MinimumDamage { get; set; }

        public int MaximumDamage { get; set; }

        //Constructors
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage)
            : base(id, name, namePlural)
        {
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
        }
    }
}
