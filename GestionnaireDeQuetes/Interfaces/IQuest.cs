using Game.Players;
using Game.Rewards;

namespace Game.Quests
{
    public interface IQuest
    {
        void Complete(Player player);
        int CalculateXp();
        Reward GetReward();
    }
}