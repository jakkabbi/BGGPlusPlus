using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class GameArtist
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? ArtistId { get; set; }
    }
}
