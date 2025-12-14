using GestionnaireDeQuetes.Interfaces;

namespace GestionnaireDeQuetes.Players
{
    public class Player
    {
        public int Id { get; }
        public string Name { get; }
        public int Experience { get; private set; }

        public List<IQuest> ActiveQuests { get; } = new();

        public Player(int id, string name)
        {
            Id = id;
            Name = string.IsNullOrWhiteSpace(name) ? "Joueur" : name;
            Experience = 0;
        }

        public void AddQuest(IQuest quest)
        {
            if (quest != null && !ActiveQuests.Contains(quest))
            {
                ActiveQuests.Add(quest);
            }
        }

        public void CompleteQuest(IQuest quest)
        {
            if (quest != null && ActiveQuests.Contains(quest))
            {
                quest.Complete(this);
                ActiveQuests.Remove(quest);
            }
        }

        public void GainXP(int amount)
        {
            if (amount > 0)
            {
                Experience += amount;
            }
        }

        public override string ToString()
        {
            return $"{Name} (ID: {Id}, XP: {Experience}, Quêtes actives: {ActiveQuests.Count})";
        }
    }
}