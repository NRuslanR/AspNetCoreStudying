namespace AspNetCoreFromScratch
{
    public class TopItemSettings
    {
        public const string MONTH = "Month";
        public const string YEAR = "Year";
        
        public string Name { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"[ \"{nameof(Name)}\" : \"{Name}\", \"{nameof(Model)}\" : \"{Model}\" ]";
        }
    }
}