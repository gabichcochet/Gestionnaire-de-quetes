namespace GestionnaireDeQuetes.Interfaces
{
    using GestionnaireDeQuetes.Models;

    public interface IRewardStrategy
    {
        Reward CalculateReward(List<IQuest> quests);
    }
}
