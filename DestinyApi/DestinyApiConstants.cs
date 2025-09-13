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
            1604785891, //K1
            1734879670, //Skywatch
            2489241976, //Caldera
            3056702872, //Conflux
            3214228047, //Creation
            4008836256, //Salt Mines
            3816084061, //Quickplay: Normal
            2700525707, //Quickplay: Advanced
            2619873230, //Quickplay: Expert
            4192328901 //Quickplay: Master
        };

        public static List<uint> FireteamOperations = new List<uint>
        {
            47604735  , //The Warrior
            112486683 , //Battleground Delve
            1019762304, //Technocrat
            1136877027, //Liminality
            1191481675, //Battleground Oracle
            1509484286, //Inverted Spire
            1655726829, //Battleground Conduit
            1977716129, //Battleground Foothold
            2751501766, //Savathun's Spire
            2963591247, //Dark Priestess
            3061857094, //Proving Grounds
            3610118907, //Devil's Lair
            4145089682, //Glassway
            86337131  , //Battleground Behemoth
            154066551 , //Cabal's Watch
            763890651 , //Hypernet Current
            1671362073, //Fallen Bunker
            1763799972, //Battleground Core
            1826451826, //Expedition Europa
            1952657885, //Insight Terminus
            2003481787, //Expedition Cosmodrome
            2396783420, //Expedition Nessus
            2638370572, //Conductor's Keep
            3363349123, //Fallen S.A.B.E.R.
            218823224 , //The Coil
            1459273759, //Contest of Elders
            732075595 , //Onslaught: Widow's Court
            849675207 , //Onslaught: Midtown
            2582324487, //Quickplay: Normal
            2866658313, //Quickplay: Advanced
            2694614320, //Quickplay: Expert
            3437865231 //Quickplay: Master
        };

        public static List<uint> PinnacleOperations = new List<uint>
        {
            576782083, //Whisper
            1768099736, //Starcrossed
            1948474391, //Kell's Fall
            3120544689, //Encore
            775989808, //Avalon
            935938264, //Presage
            3584571989, //Nightmare of Gahlran
            3996127757, //Hefund's Vengance
            1325548022 //Beneath the Necropolis
        };

        public static List<uint> Conquests = new List<uint>
        {
            3656747069, //Expert Conquest: Devils' Lair: Customize
            4089129430, //Expert Conquest: Dark Priestess: Customize
            2500578747, //Master Conquest: Conduit: Customize
            2883193556, //Master Conquest: Inverted Spire: Customize
            1645244833, //Grandmaster Conquest: Whisper: Customize
            1561490698, //Grandmaster Conquest: Delve: Customize
            2404075359, //Grandmaster Conquest: Fallen S.A.B.E.R.: Customize
            1025079976, //Grandmaster Conquest: Glassway: Customize
            1298573781, //Grandmaster Conquest: Fikrul's Castle: Customize
            2384839795, //Grandmaster Conquest: Savathûn's Spire: Customize
            123652462, //Ultimate Conquest: Hypernet: Customize
            3645820853 //Ultimate Conquest: //node.ovrd.AVALON//: Customize
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
