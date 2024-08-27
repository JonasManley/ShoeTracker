namespace ShoeTracker.frontend.Models
{
    public class Shoe
    {
        public string Name { get; set; }
        public int Kilometers { get; set; }
        public int MaxKilometers { get; set; }
        public int UsagePercentage => (int)((double)Kilometers / MaxKilometers * 100);
    }
}
