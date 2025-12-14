namespace GestionnaireDeQuetes.Models
{
    public enum QuestType
    {
        MAIN,   // Quêtes principales (scénario)
        SIDE,   // Quêtes secondaires
        DAILY,  // Quêtes journalières (réinitialisation quotidienne)
        EVENT   // Quêtes d'événement (durée limitée)
    }
}