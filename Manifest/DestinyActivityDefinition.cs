namespace Classes.Manifest
{
    public class DestinyActivityDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public DestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; set; }
        public string ReleaseIcon { get; set; }
        public int ReleaseTime { get; set; }
        public uint CompletionUnlockHash { get; set; }
        public int ActivityLightLevel { get; set; }
        public uint DestinationHash { get; set; }
        public uint PlaceHash { get; set; }
        public uint ActivityTypeHash { get; set; }
        public int Tier { get; set; }
        public string PgcrImage { get; set; }
        public List<DestinyActivityReward> Rewards { get; set; }
        public List<DestinyActivityModifier> Modifiers { get; set; }
        public bool IsPlaylist { get; set; }
        public List<object> Challenges { get; set; }
        public List<string> OptionalUnlockStrings { get; set; }
        public bool InheritFromFreeRoam { get; set; }
        public List<uint> ActivityFamilyHashes { get; set; }
        public List<uint> TraitHashes { get; set; }
        public bool SuppressOtherRewards { get; set; }
        public List<uint> SelectableSkullCollectionHashes { get; set; }
        public List<object> PlaylistItems { get; set; }
        public DestinyActivityMatchmaking Matchmaking { get; set; }
        public uint? DirectActivityModeHash { get; set; }
        public int? DirectActivityModeType { get; set; }
        public List<uint> ActivityModeHashes { get; set; }
        public List<int> ActivityModeTypes { get; set; }
        public bool IsPvP { get; set; }
        public List<object> InsertionPoints { get; set; }
        public List<object> ActivityLocationMappings { get; set; }
        public uint Hash { get; set; }
        public int Index { get; set; }
        public bool Redacted { get; set; }
        public bool Blacklisted { get; set; }
    }

    public class DestinyDisplayPropertiesDefinition
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool HasIcon { get; set; }
    }

    public class DestinyActivityReward
    {
        public string RewardText { get; set; }
        public List<DestinyActivityRewardItem> RewardItems { get; set; }
    }

    public class DestinyActivityRewardItem
    {
        public uint ItemHash { get; set; }
        public int Quantity { get; set; }
        public bool HasConditionalVisibility { get; set; }
    }

    public class DestinyActivityModifier
    {
        public uint ActivityModifierHash { get; set; }
    }

    public class DestinyActivityMatchmaking
    {
        public bool IsMatchmade { get; set; }
        public int MinParty { get; set; }
        public int MaxParty { get; set; }
        public int MaxPlayers { get; set; }
        public bool RequiresGuardianOath { get; set; }
    }
}
