using System.Collections.Generic;
using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Strategies
{
    public class FixedRewardStrategy : IRewardStrategy
    {
        private readonly Reward fixedReward;

        public FixedRewardStrategy(Reward reward)
        {
            fixedReward = reward;
        }

        public Reward CalculateReward(List<IQuest> quests)
        {
            return fixedReward;
        }
    }
}