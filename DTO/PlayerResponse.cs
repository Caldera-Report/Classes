namespace Classes.DTO
{
    public class PlayerResponse
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public int DisplayNameCode { get; set; }
        public string FullDisplayName => $"{DisplayName}#{DisplayNameCode:D4}";
        public string LastUpdateStatus { get; set; }
        public DateTime? LastProfileView { get; set; }
    }
}
