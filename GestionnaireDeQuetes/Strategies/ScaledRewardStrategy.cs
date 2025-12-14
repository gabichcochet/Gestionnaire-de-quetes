using System.Collections.Generic;
using System.Linq;
using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Strategies
{
    public class ScaledRewardStrategy : IRewardStrategy
    {
        private readonly int baseValue;

        public ScaledRewardStrategy(int baseValue)
        {
            this.baseValue = baseValue;
        }

        public Reward CalculateReward(List<IQuest> quests)
        {
            int totalXP = quests.Sum(q => q.CalculateXP());
            return new Reward("Récompense proportionnelle", baseValue + totalXP);
        }
    }
}