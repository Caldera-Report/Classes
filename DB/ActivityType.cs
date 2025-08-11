namespace Classes.DB
{
    public class ActivityType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long OpTypeId { get; set; }

        public ICollection<Activity> Activities { get; set; }
        public OpType OpType { get; set; }
    }
}
