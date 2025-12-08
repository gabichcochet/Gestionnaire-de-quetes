using GestionnaireDeQuetes.Interfaces;

namespace GestionnaireDeQuetes.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; private set; }

        public List<IQuest> ActiveQuests { get; set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            ActiveQuests = new List<IQuest>();
        }

        public void AddQuest(IQuest quest)
        {
            ActiveQuests.Add(quest);
        }

        public void CompleteQuest(IQuest quest)
        {
            quest.Complete(this);
            ActiveQuests.Remove(quest);
        }

        public void GainXP(int amount)
        {
            Experience += amount;
        }
    }
}
