using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Players;

namespace GestionnaireDeQuetes.Managers
{
    public class QuestManager
    {
        private readonly List<IQuest> quests = new();
        private readonly List<IQuestObserver> observers = new();

        public void AddQuest(IQuest quest)
        {
            quests.Add(quest);
        }

        public void RemoveQuest(IQuest quest)
        {
            quests.Remove(quest);
        }

        public void AssignQuest(Player player, IQuest quest)
        {
            player.AddQuest(quest);
            AddQuest(quest);
        }

        public List<IQuest> GetPlayerQuests(Player player)
        {
            return player.ActiveQuests;
        }

        public void AddObserver(IQuestObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void RemoveObserver(IQuestObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void NotifyObservers(IQuest quest, Player player)
        {
            foreach (var observer in observers)
            {
                observer.OnQuestCompleted(quest, player);
            }
        }

        public void CompleteQuest(IQuest quest, Player player)
        {
            quest.Complete(player);
            NotifyObservers(quest, player);
        }

        public void CompleteAllQuests(Player player, IEnumerable<IQuest> questsToComplete)
        {
            foreach (var quest in questsToComplete)
            {
                CompleteQuest(quest, player);
            }
        }
    }
}