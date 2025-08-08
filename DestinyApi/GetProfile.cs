﻿namespace Classes.DestinyApi
{
    public class DestinyProfileResponse
    {
        public DateTime responseMintedTimestamp {  get; set; }
        public DateTime secondaryComponentsMintedTimestamp { get; set; }
        public DictionaryComponentResponseOfint64AndDestinyCharacterComponent characters { get; set; }
    }

    public class DictionaryComponentResponseOfint64AndDestinyCharacterComponent
    {
        public DestinyCharacterComponent data { get; set; }
        public int privacy { get; set; }
        public bool disabled { get; set; }
    }

    public class DestinyCharacterComponent
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public string characterId { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public string minutesPlayedThisSession { get; set; }
        public string minutesPlayedTotal { get; set; }
        public int light {  get; set; }
        public string emblemPath { get; set; }
        public string emblemBackgroundPath { get; set; }
    }
}
