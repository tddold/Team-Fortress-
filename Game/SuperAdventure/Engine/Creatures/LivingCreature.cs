namespace Engine
{
    using Engine.Interfaces;

    public abstract class LivingCreature : ILiving
    {
        //Properties
        public int CurrentHitPoints { get; set; }

        public int MaximumHitPoints { get; set; }

        //Constructor
        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            this.CurrentHitPoints = currentHitPoints;
            this.MaximumHitPoints = maximumHitPoints;
        }
    }
}
