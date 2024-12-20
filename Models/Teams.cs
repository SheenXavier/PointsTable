﻿namespace PointsTable.Models
{
    public class Teams
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference { get; set; }
    }
}
