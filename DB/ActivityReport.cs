namespace Classes.DB
{
    public class ActivityReport
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long PlayerId { get; set; }
        public long ActivityId { get; set; }
        public bool Completed { get; set; }
        public long Duration { get; set; }

        public Player Player { get; set; }
        public Activity Activity { get; set; }
    }
}