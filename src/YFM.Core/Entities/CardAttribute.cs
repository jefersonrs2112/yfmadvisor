namespace YFM.Core.Entities
{
    public class CardAttribute
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
