using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Strategies
{
    public class FixedRewardStrategy : IRewardStrategy
    {
        private Reward reward;

        public FixedRewardStrategy(Reward reward)
        {
            this.reward = reward;
        }

        public Reward CalculateReward(List<IQuest> quests)
        {
            return reward;
        }
    }
}
