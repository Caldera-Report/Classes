namespace Classes.DB
{
    public class PlayerActivityRecord
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public long ActivityId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string FastestCompletion { get; set; }
        public long FastestCompletionActivityReportId { get; set; }
        public string TotalTimePlayed { get; set; }
        public string TotalGamesPlayed { get; set; }

        public Player Player { get; set; }
        public Activity Activity { get; set; }
        public ActivityReport FastestCompletionActivityReport { get; set; }
    }
}
