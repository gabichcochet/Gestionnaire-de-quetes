namespace GestionnaireDeQuetes.Models
{
    public class Reward
    {
        public int Gold { get; set; }
        public int Items { get; set; }

        public Reward(int gold = 0, int items = 0)
        {
            Gold = gold;
            Items = items;
        }
    }
}
