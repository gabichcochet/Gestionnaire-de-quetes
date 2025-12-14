using GestionnaireDeQuetes.Models;
using GestionnaireDeQuetes.Players;

namespace GestionnaireDeQuetes.Interfaces
{
    public interface IQuest
    {        
        string Title { get; }
        string Description { get; }

        int CalculateXP();
        Reward GetReward();
        void Complete(Player player);
    }
}
