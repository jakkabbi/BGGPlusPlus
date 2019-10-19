using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.Models
{
    public partial class Games
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int? Category { get; set; }
        public int? MinPlayers { get; set; }
        public int? MaxPlayers { get; set; }
        public int? SugPlayers { get; set; }
        public string GameDesc { get; set; }
        public int? PlaytimeMin { get; set; }
        public int? PlaytimeMax { get; set; }
        public double? ReviewScore { get; set; }
        public int? NumReviews { get; set; }
        public double? Complexity { get; set; }
        public int? AgeMin { get; set; }
        public int? AgeMax { get; set; }
    }
}
