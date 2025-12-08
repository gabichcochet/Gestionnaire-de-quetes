using GestionnaireDeQuetes.Interfaces;

namespace GestionnaireDeQuetes.Models
{
    public class SimpleQuest : IQuest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public QuestType Type { get; set; }
        public Reward Reward { get; set; }

        public SimpleQuest(int id, string title, string desc, QuestType type, Reward reward)
        {
            Id = id;
            Title = title;
            Description = desc;
            Type = type;
            Reward = reward;
        }

        public void Complete(Player player)
        {
            player.GainXP(CalculateXP());
        }

        public int CalculateXP()
        {
            return 100;
        }

        public Reward GetReward()
        {
            return Reward;
        }
    }
}
