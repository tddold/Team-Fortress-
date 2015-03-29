namespace Engine
{
    using Engine.Interfaces;

    public class LivingCreature : ILiving
    {
        public int CurrentHitPoints { get; set; }

        public int MaximumHitPoints { get; set; }

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            this.CurrentHitPoints = currentHitPoints;
            this.MaximumHitPoints = maximumHitPoints;
        }
    }
}
