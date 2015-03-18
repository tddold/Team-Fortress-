namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Weapon : Item
    {
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage)
            : base(id, name, namePlural)
        {
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
        }

        public int MinimumDamage { get; set; }

        public int MaximumDamage { get; set; }
    }
}
