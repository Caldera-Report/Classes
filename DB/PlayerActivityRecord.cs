namespace Classes.DB
{
    public class PlayerActivityRecord
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public long ActivityId { get; set; }
        public TimeSpan FastestCompletion { get; set; }
        public long FastestCompletionActivityReportId { get; set; }
        public TimeSpan TotalTimePlayed { get; set; }
        public int TotalGamesPlayed { get; set; }

        public Player Player { get; set; }
        public Activity Activity { get; set; }
        public ActivityReport FastestCompletionActivityReport { get; set; }

        public static bool operator >(PlayerActivityRecord record1, PlayerActivityRecord record2)
        {
            if (record1.FastestCompletion < record2.FastestCompletion)
                return true;
            else
            {
                if (record1.TotalGamesPlayed > record2.TotalGamesPlayed)
                    return true;
                else
                    return false;
            }
        }

        public static bool operator <(PlayerActivityRecord record1, PlayerActivityRecord record2)
        {
            if (record1.FastestCompletion > record2.FastestCompletion)
                return true;
            else
            {
                if (record1.TotalGamesPlayed < record2.TotalGamesPlayed)
                    return true;
                else
                    return false;
            }
        }
    }
}
