namespace Classes.DB
{
    public class ActivityType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public ICollection<Activity> Activities { get; set; }
    }
}
