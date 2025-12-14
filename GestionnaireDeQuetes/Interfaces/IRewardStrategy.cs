using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Interfaces
{
    public interface IRewardStrategy
    {
        Reward CalculateReward(List<IQuest> quests);
    }
}