using GestionnaireDeQuetes.Players;

namespace GestionnaireDeQuetes.Interfaces
{
    public interface IQuestObserver
    {
        void OnQuestCompleted(IQuest quest, Player player);
    }
}
