
namespace Engine.Interfaces
{
    public interface IReward : IPersonalization 
    {
        int RewardExperiencePoints { get; set; }

        int RewardGold { get; set; }
    }
}
