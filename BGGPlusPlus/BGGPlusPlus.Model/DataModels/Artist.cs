using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class Artist
    {
        public Artist()
        {
            GameArtist = new HashSet<GameArtist>();
        }

        public int Id { get; set; }
        public string Artist1 { get; set; }

        public virtual ICollection<GameArtist> GameArtist { get; set; }
    }
}
