﻿namespace Classes.DTO
{
    public class StatisticsResponse
    {
        public int CalderaCompletions { get; set; }
        public string? CalderaFastestCompletion { get; set; }
        public int K1Completions { get; set; }
        public string? K1FastestCompletion { get; set; }
        public int KellsFallCompletions { get; set; }
        public string? KellsFallFastestCompletion { get; set; }
        public int EncoreCompletions { get; set; }
        public string? EncoreFastestCompletion { get; set; }
    }
}
