namespace Classes.DTO
{
    public class ActivityReportResponse
    {
        public long Id { get; set; }
        public long InstanceId { get; set; }
        public DateTime Date { get; set; }
        public long PlayerId { get; set; }
        public long ActivityId { get; set; }
        public bool Completed { get; set; }
        public TimeSpan Duration { get; set; }

        public PlayerResponse Player { get; set; }
        public ActivityResponse Activity { get; set; }
    }
}
