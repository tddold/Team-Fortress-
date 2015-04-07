namespace Engine.Interfaces
{
    public interface ILiving
    {
        int CurrentHitPoints { get; set; }

        int MaximumHitPoints { get; set; }
    }
}
