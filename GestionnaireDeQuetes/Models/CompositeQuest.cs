using GestionnaireDeQuetes.Interfaces;

namespace GestionnaireDeQuetes.Models
{
    public class CompositeQuest : IQuest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<IQuest> Subquests { get; set; }
        public IRewardStrategy RewardStrategy { get; set; }

        public CompositeQuest(int id, string title, string desc, IRewardStrategy rewardStrategy)
        {
            Id = id;
            Title = title;
            Description = desc;
            RewardStrategy = rewardStrategy;
            Subquests = new List<IQuest>();
        }

        public void Complete(Player player)
        {
            foreach (var quest in Subquests)
                quest.Complete(player);

            player.GainXP(CalculateXP());
        }

        public int CalculateXP()
        {
            return Subquests.Count * 100;
        }

        public Reward GetReward()
        {
            return RewardStrategy.CalculateReward(Subquests);
        }
    }
}
