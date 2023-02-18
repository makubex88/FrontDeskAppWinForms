namespace FrontDeskAppAPI.Model
{
    public class Storage
    {
        public int Id { get; set; }
        public string StorageName { get; set; }
        public int TotalOfSmallStorage { get; set; }
        public int TotalOfMediumStorage { get; set; }
        public int TotalOfLargeStorage { get; set; }
    }
}
