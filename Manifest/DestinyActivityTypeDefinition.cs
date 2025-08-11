namespace Classes.Manifest
{
    public class DestinyActivityTypeDefinition
    {
        public Displayproperties displayProperties { get; set; }
        public long hash { get; set; }
        public int index { get; set; }
        public bool redacted { get; set; }
        public bool blacklisted { get; set; }
    }

    public class Displayproperties
    {
        public string description { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public bool hasIcon { get; set; }
    }

}
