namespace Classes.DTO
{
    public class SearchResponse
    {
        public required List<SearchResult> Results { get; set; }
    }
    public class SearchResult
    {
        public required string DisplayName { get; set; }
        public required int DisplayNameCode { get; set; }
        public required string DestinyMembershipId { get; set; }
        public required int MembershipType { get; set; }
    }
}
