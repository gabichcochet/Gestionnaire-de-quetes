using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Strategies
{
    public class ScaledRewardStrategy : IRewardStrategy
    {
        public Reward CalculateReward(List<IQuest> quests)
        {
            int gold = quests.Count * 50;
            int items = quests.Count;

            return new Reward(gold, items);
        }
    }
}
