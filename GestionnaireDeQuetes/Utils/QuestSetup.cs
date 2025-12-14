using GestionnaireDeQuetes.Enums;
using GestionnaireDeQuetes.Factories;
using GestionnaireDeQuetes.Interfaces;
using GestionnaireDeQuetes.Models;
using GestionnaireDeQuetes.Players;
using GestionnaireDeQuetes.Quests;
using GestionnaireDeQuetes.Strategies;

namespace GestionnaireDeQuetes.Utils
{
    public static class QuestSetup
    {
        public static List<IQuest> CreateSimpleQuests(Player player)
        {
            var quest1 = QuestFactory.CreateSimpleQuest(
                100,
                "Explorer la forêt",
                "Trouver le chemin caché dans la forêt",
                QuestType.Exploration,
                new Reward("Or", 20)
            );

            var quest2 = QuestFactory.CreateSimpleQuest(
                101,
                "Combattre le gobelin",
                "Vaincre le gobelin qui terrorise le village",
                QuestType.Combat,
                new Reward("Épée", 30)
            );

            player.AddQuest(quest1);
            player.AddQuest(quest2);

            Console.WriteLine($"✅ Quête simple '{quest1.Title}' ajoutée au joueur !");
            Console.WriteLine($"✅ Quête simple '{quest2.Title}' ajoutée au joueur !");

            return new List<IQuest> { quest1, quest2 };
        }

        public static CompositeQuest CreateCompositeQuest(Player player)
        {
            var subQuest1 = QuestFactory.CreateSimpleQuest(
                200,
                "Collecter des herbes",
                "Ramasser 10 herbes médicinales",
                QuestType.Collection,
                new Reward("Potion", 15)
            );

            var subQuest2 = QuestFactory.CreateSimpleQuest(
                201,
                "Parler au sage",
                "Obtenir des conseils auprès du sage du village",
                QuestType.Dialogue,
                new Reward("Sagesse", 25)
            );

            var subQuests = new List<IQuest> { subQuest1, subQuest2 };

            var compositeQuest = QuestFactory.CreateCompositeQuest(
                300,
                "Grande aventure",
                "Accomplir plusieurs étapes pour sauver le royaume",
                new ScaledRewardStrategy(10), // stratégie par défaut
                subQuests
            );

            player.AddQuest(compositeQuest);

            Console.WriteLine($"✅ Quête composite '{compositeQuest.Title}' ajoutée au joueur avec {subQuests.Count} sous-quêtes !");
            compositeQuest.DisplaySubQuests();

            return compositeQuest;
        }
    }
}