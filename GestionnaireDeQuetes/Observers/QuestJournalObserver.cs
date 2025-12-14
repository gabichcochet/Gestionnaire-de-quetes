using GestionnaireDeQuetes.Players;
using GestionnaireDeQuetes.Interfaces;

namespace GestionnaireDeQuetes.Observers
{
    public class QuestJournalObserver : IQuestObserver
    {
        private readonly QuestJournal journal;

        public QuestJournalObserver(QuestJournal journal)
        {
            this.journal = journal;
        }

        public void OnQuestCompleted(IQuest quest, Player player)
        {
            journal.AddCompletedQuest(quest);
            Console.WriteLine($"[Observer] {player.Name} a complété la quête : {quest.Title}");
        }
    }
}