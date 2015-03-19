namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HealingPotion : Item
    {
        public HealingPotion(int id, string name, string namePlural, PotionType size)
            : base(id, name, namePlural)
        {
            this.Size = size;
        }

        public PotionType Size { get; set; }

        public void PotionUse (int currentHealth, int maxHealth, PotionType potion)
        {
            double healingPoint;
            switch ((int)potion)
            {
                case 0: 
                    healingPoint = Math.Floor (maxHealth * 0.3);
                    currentHealth += (int)healingPoint;
                    if (currentHealth > maxHealth)
                    {
                        currentHealth = maxHealth;
                    }
                    return;
                case 1:
                    healingPoint = Math.Floor(maxHealth * 0.5);
                    currentHealth += (int)healingPoint;
                    if (currentHealth > maxHealth)
                    {
                        currentHealth = maxHealth;
                    }
                    return;
                case 2:
                    currentHealth = maxHealth;
                    return;
            }
        }
    }
}
