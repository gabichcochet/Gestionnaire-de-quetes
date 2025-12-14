using Game.Quests;  

namespace Game.Players
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Experience { get; set; }
        public List<IQuest> ActiveQuests { get; set; } = new();

        public void AddQuest(IQuest quest)
        {
            ActiveQuests.Add(quest);
        }

        public void CompleteQuest(IQuest quest)
        {
            quest.Complete(this);
            ActiveQuests.Remove(quest);
        }

        public void GainXp(int amount)
        {
            Experience += amount;
        }
    }
}