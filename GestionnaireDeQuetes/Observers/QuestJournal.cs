using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Players;

namespace GestionnaireDeQuetes.Observers
{
    public class QuestJournal
    {
        public Player Player { get; private set; }

        public List<IQuest> CompletedQuests { get; private set; } = new();

        public QuestJournal(Player player)
        {
            Player = player;
        }

        public void AddCompletedQuest(IQuest quest)
        {
            if (quest != null && !CompletedQuests.Contains(quest))
            {
                CompletedQuests.Add(quest);
            }
        }

        public void MarkCompletedQuests(IEnumerable<IQuest> quests)
        {
            foreach (var quest in quests)
            {
                AddCompletedQuest(quest);
            }
        }

        public void MarkCompositeQuest(IQuest compositeQuest)
        {
            AddCompletedQuest(compositeQuest);
        }

        public List<IQuest> GetCompletedQuests()
        {
            return CompletedQuests;
        }

        public override string ToString()
        {
            return $"Journal de {Player.Name} : {CompletedQuests.Count} quêtes complétées.";
        }
    }
}