namespace Classes.DestinyApi
{
    public class DestinyPostGameCarnageReportData
    {
        public DateTime period {  get; set; }
        public int difficultyTier { get; set; }
        public DestinyHistoricalStatsActivity activityDetails { get; set; }
        public DestinyPostGameCarnageReportEntry entries { get; set; }
    }

    public class DestinyPostGameCarnageReportEntry
    {
        public DestinyHistoricalStatsValue score { get; set; }
        public DestinyPlayer player { get; set; }
        public string characterId { get; set; }
        public Dictionary<string, DestinyHistoricalStatsValue> values { get; set; }
        public DestinyPostGameCarnageReportExtendedData extended { get; set; }
    }

    public class DestinyPlayer
    {
        public UserInfoCard destinyUserInfo { get; set; }
        public string characterClass { get; set; }
        public uint classHash {  get; set; }
        public string clanTag { get; set; }
        public uint emblemHash { get; set; }
    }

    public class DestinyPostGameCarnageReportExtendedData
    { 
        public DestinyHistoricalWeaponStats weapons { get; set; }
        public Dictionary<string, DestinyHistoricalStatsValue> values { get; set; }
    }

    public class DestinyHistoricalWeaponStats
    {
        public uint referenceId { get; set; }
        public Dictionary<string, DestinyHistoricalStatsValue> values { get; set; }
    }
}
