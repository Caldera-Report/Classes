namespace Classes.DB
{
    public class ActivityHashMapping
    {
        public long SourceHash { get; set; }
        public long CanonicalActivityId { get; set; }
        public Activity CanonicalActivity { get; set; }
    }
}
