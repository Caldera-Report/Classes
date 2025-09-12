using Classes.DB;

namespace Classes.DestinyApi
{
    public static class DestinyApiConstants
    {
        public static List<int> NonRetryableBungieErrorCodes = new List<int>
        {
            1601, 1665
        };

        public const uint SoloOps = 3851289711;
        public const uint Strikes = 556925641;
        public const uint Nightfall = 575572995;
        public const uint Crawl = 2442898492;
        public const uint Onslaught = 2897687202;
        public const uint ExoticMission = 1227821118;

        public static List<uint> SoloOperations = new List<uint>
        {
            1604785891,
            1734879670,
            2489241976,
            3056702872,
            3214228047,
            4008836256,
            3816084061,
            2700525707,
            2619873230,
            4192328901
        };

        public static List<uint> FireteamOperations = new List<uint>
        {
            47604735  ,
            112486683 ,
            1019762304,
            1136877027,
            1191481675,
            1509484286,
            1655726829,
            1977716129,
            2751501766,
            2963591247,
            3061857094,
            3610118907,
            4145089682,
            86337131  ,
            154066551 ,
            763890651 ,
            1671362073,
            1763799972,
            1826451826,
            1952657885,
            2003481787,
            2396783420,
            2638370572,
            3363349123,
            218823224 ,
            1459273759,
            732075595 ,
            849675207 ,
            2582324487,
            2866658313,
            2694614320,
            3437865231
        };

        public static List<uint> PinnacleOperations = new List<uint>
        {
            576782083,
            1768099736,
            1948474391,
            3120544689,
            3584571989,
            3996127757,
            1325548022
        };

        public static List<uint> Conquests = new List<uint>
        {
            3656747069,
            4089129430,
            2500578747,
            2883193556,
            1645244833,
            1561490698,
            2404075359,
            1025079976,
            1298573781,
            2384839795,
            123652462,
            3645820853
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
            },
            new OpType()
            {
                Name = "Conquest"
            }
        };
    }
}
