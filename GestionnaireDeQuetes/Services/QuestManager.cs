using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Services
{
    public class QuestManager
    {
        public List<IQuest> Quests { get; set; }
        public List<Player> Players { get; set; }

        public QuestManager()
        {
            Quests = new List<IQuest>();
            Players = new List<Player>();
        }

        public void AddQuest(IQuest quest)
        {
            Quests.Add(quest);
        }

        public void RemoveQuest(IQuest quest)
        {
            Quests.Remove(quest);
        }

        public void AssignQuestToPlayer(Player player, IQuest quest)
        {
            player.AddQuest(quest);
        }

        public List<IQuest> GetPlayerQuests(Player player)
        {
            return player.ActiveQuests;
        }
    }
}
