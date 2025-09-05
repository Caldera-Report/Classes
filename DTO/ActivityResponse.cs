namespace Classes.DTO
{
    public class ActivityResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public ActivityTypeResponse ActivityType { get; set; }
    }
}
