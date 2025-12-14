namespace GestionnaireDeQuetes.Models
{
    public class Reward
    {
        public string Description { get; set; }
        
        public int Value { get; set; }

        public Reward(string description, int value)
        {
            Description = description;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Description} (Valeur: {Value})";
        }
    }
}