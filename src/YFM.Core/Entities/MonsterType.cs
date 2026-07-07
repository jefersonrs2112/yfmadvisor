namespace YFM.Core.Entities
{
    public class MonsterType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
