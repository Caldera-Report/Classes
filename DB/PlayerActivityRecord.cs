namespace Classes.DB
{
    public class PlayerActivityRecord
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public long ActivityId { get; set; }
        public TimeSpan FastestCompletion { get; set; }
        public long FastestCompletionActivityReportInstanceId { get; set; }
        public TimeSpan TotalTimePlayed { get; set; }
        public int TotalGamesPlayed { get; set; }

        public Player Player { get; set; }
        public Activity Activity { get; set; }
        public ActivityReport FastestCompletionActivityReport { get; set; }
    }
}
