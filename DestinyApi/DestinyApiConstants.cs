using Classes.DB;

namespace Classes.DestinyApi
{
    public static class DestinyApiConstants
    {
        public static List<uint> AllActivities = new List<uint>
        {
            2489241976, 3120544689, 1948474391, 528371307, 1037546335, 167985894, 2213088605, 1604785891
        };

        public static List<uint> K1 = new List<uint>
            {
                528371307, 1037546335, 167985894, 2213088605, 1604785891
            };

        public const uint Caldera = 2489241976;
        public const uint Encore = 3120544689;
        public const uint KellsFall = 1948474391;

        public const uint SoloOps = 3851289711;
        public const uint Strikes = 556925641;
        public const uint Crawl = 2442898492;
        public const uint Onslaught = 2897687202;
        public const uint ExoticMission = 1227821118;

        public static List<uint> SoloOperations = new List<uint>
        {
            SoloOps
        };

        public static List<uint> FireteamOperations = new List<uint>
        {
            Strikes, Crawl, Onslaught
        };

        public static List<uint> PinnacleOperations = new List<uint>
        {
            ExoticMission
        };

        public static List<OpType> OperationTypes = new List<OpType>
        {
            new OpType()
            {
                Name = "Solo Ops"
            },
            new OpType()
            {
                Name = "Fireteam Ops"
            },
            new OpType()
            {
                Name = "Pinnacle Ops"
            }
        };
    }
}
