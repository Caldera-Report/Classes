namespace Classes.DB
{
    public class OpType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ActivityType> ActivityTypes { get; set; }
    }
}
