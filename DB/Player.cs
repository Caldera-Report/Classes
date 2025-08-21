namespace Classes.DB
{
    public class Player
    {
        public long Id { get; set; }
        public int MembershipType { get; set; }
        public string DisplayName { get; set; }
        public int DisplayNameCode { get; set; }
        public DateTime? LastPlayed { get; set; }
        public long LastPlayedActivityInstanceId { get; set; }
        public DateTime LastUpdateStarted { get; set; }
        public DateTime LastUpdateCompleted { get; set; }
        public DateTime NextUpdate { get; set; }
        public string LastUpdateStatus { get; set; }

        public ICollection<ActivityReport> ActivityReports { get; set; }
        //public ActivityReport? LastActivityReport { get; set; }
    }
}
