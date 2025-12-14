using System;

namespace GestionnaireDeQuetes.Models
{
    public class Player
    {
        public int Experience { get; private set; }
        public int Gold { get; private set; }
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
            Experience = 0;
            Gold = 0;
        }

        public void AddExperience(int amount)
        {
            if (amount > 0)
            {
                Experience += amount;
                Console.WriteLine($"🎉 {Name} a gagné {amount} XP. Total: {Experience}");
            }
        }

        public void AddGold(int amount)
        {
            if (amount > 0)
            {
                Gold += amount;
                Console.WriteLine($"💰 {Name} a gagné {amount} pièces d'or. Total: {Gold}");
            }
        }
    }
}