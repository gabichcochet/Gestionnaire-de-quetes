using System;
using System.Collections.Generic;
using GestionnaireDeQuetes.Enums;
using GestionnaireDeQuetes.Models;
using GestionnaireDeQuetes.Quests;
using GestionnaireDeQuetes.Interfaces;

namespace GestionnaireDeQuetes.Factories
{
    public static class QuestFactory
    {
        public static SimpleQuest CreateSimpleQuest(int id, string title, string description, QuestType type, Reward reward)
        {
            return new SimpleQuest(id, title, description, type, reward);
        }
        public static CompositeQuest CreateCompositeQuest(int id, string title, string description, IRewardStrategy strategy, List<IQuest> subQuests)
        {
            CompositeQuest composite = new CompositeQuest(id, title, description, strategy);

            if (subQuests != null)
            {
                foreach (var quest in subQuests)
                {
                    composite.SubQuests.Add(quest);
                }
            }
            return composite;
        }
    }
}