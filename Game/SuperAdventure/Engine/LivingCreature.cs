namespace Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LivingCreature
    {
        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            this.CurrentHitPoints = currentHitPoints;
            this.MaximumHitPoints = maximumHitPoints;
        }

        public int CurrentHitPoints { get; set; }

        public int MaximumHitPoints { get; set; }
    }
}
