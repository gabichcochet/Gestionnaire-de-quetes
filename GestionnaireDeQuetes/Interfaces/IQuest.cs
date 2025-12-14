namespace GestionnaireDeQuetes.Interfaces
{
    public interface IQuest
    {
        // Propriétés de base
        string Title { get; }
        string Description { get; }
        bool IsCompleted { get; }
        Models.QuestType Type { get; }
        Models.Reward Reward { get; }

        // Méthode pour démarrer la quête (si nécessaire)
        void Start();

        // Méthode pour vérifier si les conditions de complétion sont remplies
        bool CheckCompletion();

        // Méthode pour marquer la quête comme complétée et appliquer la récompense
        void Complete(Models.Player player);

        // Méthode pour l'avancement (pour les quêtes composites, elle pourrait
        // déléguer aux sous-quêtes, ou pour les simples, gérer un compteur).
        void Advance(string objectiveIdentifier, int progress);
    }
}