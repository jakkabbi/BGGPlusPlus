using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class Publisher
    {
        public Publisher()
        {
            GamePublisher = new HashSet<GamePublisher>();
        }

        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<GamePublisher> GamePublisher { get; set; }
    }
}
