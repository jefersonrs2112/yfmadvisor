namespace YFM.Core.Entities
{
    public class CardImage
    {
        public int CardId { get; set; }

        public string OriginalFile { get; set; }

        public string Hash { get; set; }

        public string AverageHash { get; set; }

        public string DifferenceHash { get; set; }

        public string PerceptualHash { get; set; }
    }
}
