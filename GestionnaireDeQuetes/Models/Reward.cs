using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Strategies;

namespace GestionnaireDeQuetes.Models
{
    public class Reward
    {
        public int ExperienceAmount { get; }
        public int GoldAmount { get; }
        // On pourrait ajouter des Items, etc.

        // Utilisation de la stratégie par défaut si non spécifiée
        public IRewardStrategy Strategy { get; }

        public Reward(int xp, int gold, IRewardStrategy strategy = null)
        {
            ExperienceAmount = xp;
            GoldAmount = gold;
            // Fournit une stratégie par défaut si aucune n'est passée
            Strategy = strategy ?? new BasicRewardStrategy();
        }

        public void Deliver(Player player)
        {
            Strategy.ApplyReward(player, this);
        }
    }
}