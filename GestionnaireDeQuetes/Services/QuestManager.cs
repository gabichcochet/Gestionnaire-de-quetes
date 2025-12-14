using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;

namespace GestionnaireDeQuetes.Services
{
    public class QuestManager
    {
        public List<IQuest> Quests { get; } = new();
        public List<Player> Players { get; } = new();

        public void AddQuest(IQuest quest)
        {
            Quests.Add(quest);
        }

        public void AssignQuestToPlayer(Player player, IQuest quest)
        {
            player.ActiveQuests.Add(quest);
        }

        public Player? GetPlayerById(int id)
        {
            return Players.FirstOrDefault(p => p.Id == id);
        }

        public List<IQuest> GetPlayerQuests(Player player)
        {
            return player.ActiveQuests;
        }
    }
}
