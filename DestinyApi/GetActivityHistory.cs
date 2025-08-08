namespace Classes.DestinyApi
{
    public class DestinyActivityHistoryResults
    { 
        public List<DestinyHistoricalStatsPeriodGroup> activities { get; set; }
    }

    public class DestinyHistoricalStatsPeriodGroup
    {
        public DateTime period { get; set; }
        public DestinyHistoricalStatsActivity activities { get; set; }
        public Dictionary<string, DestinyHistoricalStatsValue> values { get; set; }
    }

    public class DestinyHistoricalStatsActivity
    {
        public uint referenceId { get; set; } //activityHash - Even the docs say so
        public string instanceId { get; set; }
    }
}
