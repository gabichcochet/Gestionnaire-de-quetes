namespace GestionnaireDeQuetes.Interfaces
{
    using GestionnaireDeQuetes.Models;

    public interface IQuest
    {
        void Complete(Player player);
        int CalculateXP();
        Reward GetReward();
    }
}
