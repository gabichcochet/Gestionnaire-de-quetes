using GestionnaireDeQuetes.Interfaces;

namespace GestionnaireDeQuetes.Models
{
    public class QuestJournal
    {
        public List<IQuest> Quests { get; set; }
        public Player Owner { get; set; }

        public QuestJournal(Player owner)
        {
            Owner = owner;
            Quests = new List<IQuest>();
        }

        public void AddQuest(IQuest quest)
        {
            Quests.Add(quest);
        }

        public void RemoveQuest(IQuest quest)
        {
            Quests.Remove(quest);
        }

        public void MarkAsCompleted(IQuest quest)
        {
            quest.Complete(Owner);
            Quests.Remove(quest);
        }

        public List<IQuest> GetActiveQuests()
        {
            return Quests;
        }

        public List<IQuest> GetCompletedQuests()
        {
            return new List<IQuest>();
        }
    }
}
