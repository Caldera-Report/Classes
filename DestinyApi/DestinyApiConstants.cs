using Classes.DB;

namespace Classes.DestinyApi
{
    public static class DestinyApiConstants
    {
        public static List<int> NonRetryableBungieErrorCodes = new List<int>
        {
            1601, 1665
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
