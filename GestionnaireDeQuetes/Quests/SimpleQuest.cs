using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;
using GestionnaireDeQuetes.Players;
using GestionnaireDeQuetes.Enums;

namespace GestionnaireDeQuetes.Quests
{
    public class SimpleQuest : IQuest
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public QuestType Type { get; set; }

        public Reward Reward { get; set; }
        public SimpleQuest(int id, string title, string description, QuestType type, Reward reward)
        {
            Id = id;
            Title = title;
            Description = description;
            Type = type;
            Reward = reward;
        }
        public void Complete(Player player)
        {
            player.GainXP(CalculateXP());
        }

        public int CalculateXP()
        {
            return Reward.Value;
        }

        public Reward GetReward()
        {
            return Reward;
        }
    }
}