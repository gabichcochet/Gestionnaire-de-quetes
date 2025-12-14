using System;
using System.Collections.Generic;
using System.Linq;
using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;
using GestionnaireDeQuetes.Players;

namespace GestionnaireDeQuetes.Quests
{
    public class CompositeQuest : IQuest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<IQuest> SubQuests { get; set; } = new();
        public IRewardStrategy RewardStrategy { get; set; }

        public CompositeQuest(int id, string title, string description, IRewardStrategy rewardStrategy)
        {
            Id = id;
            Title = title;
            Description = description;
            RewardStrategy = rewardStrategy;
        }

        public void Complete(Player player)
        {
            foreach (var quest in SubQuests)
            {
                quest.Complete(player);
            }
        }

        public int CalculateXP()
        {
            return SubQuests.Sum(q => q.CalculateXP());
        }

        public Reward GetReward()
        {
            return RewardStrategy.CalculateReward(SubQuests);
        }

        public void DisplaySubQuests()
        {
            Console.WriteLine($"\n--- Sous-quêtes de '{Title}' ---");
            foreach (var quest in SubQuests)
            {
                Console.WriteLine($"• {quest.Title} : {quest.Description} (XP: {quest.CalculateXP()})");
            }
        }
    }
}