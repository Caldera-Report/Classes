namespace Classes.DB
{
    public class Player
    {
        public long Id { get; set; }
        public int MembershipType { get; set; }
        public required string DisplayName { get; set; }
        public int DisplayNameCode { get; set; }
        public string? LastPlayedCharacterEmblemPath { get; set; }
        public string? LastPlayedCharacterBackgroundPath { get; set; }
        public DateTime? LastPlayed { get; set; }
        public long? LastPlayedActivityId { get; set; }
        public DateTime? LastUpdateStarted { get; set; }
        public DateTime? LastUpdateCompleted { get; set; }
        public DateTime? LastProfileView { get; set; }
        public int UpdatePriority { get; set; }
        public string? LastUpdateStatus { get; set; }
        public bool NeedsFullCheck { get; set; }

        public ICollection<ActivityReport>? ActivityReports { get; set; }
        public ActivityReport? LastActivityReport { get; set; }
    }
}
