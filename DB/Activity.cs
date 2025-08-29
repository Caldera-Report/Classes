namespace Classes.DB
{
    public class Activity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public long ActivityTypeId { get; set; }

        public ICollection<ActivityReport> ActivityReports { get; set; }
        public ActivityType ActivityType { get; set; }
    }
}
