using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Interfaces
{
    public interface IRewardStrategy
    {
        /// <summary>
        /// Applique la récompense au joueur.
        /// </summary>
        /// <param name="player">Le joueur à récompenser.</param>
        /// <param name="reward">L'objet récompense contenant les détails.</param>
        void ApplyReward(Player player, Reward reward);
    }
}