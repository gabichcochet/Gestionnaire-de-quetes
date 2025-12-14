using GestionnaireDeQuetes.Players;
using GestionnaireDeQuetes.Managers;
using GestionnaireDeQuetes.Observers;
using GestionnaireDeQuetes.Utils;

namespace GestionnaireDeQuetes
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(1, "William");
            var journal = new QuestJournal(player);
            var manager = new QuestManager();
            manager.AddObserver(new QuestJournalObserver(journal));

            Console.WriteLine($"\n✅ Joueur créé : {player.Name} (ID: {player.Id})\n");

            var simpleQuests = QuestSetup.CreateSimpleQuests(player);
            var compositeQuest = QuestSetup.CreateCompositeQuest(player);

            Console.WriteLine("\n=== Complétion ===");
            manager.CompleteAllQuests(player, simpleQuests.Append(compositeQuest));

            Console.WriteLine("\n=== Résultats ===");
            Console.WriteLine(player);
            Console.WriteLine(journal);
        }
    }
}