using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class GamePublisher
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? PublisherId { get; set; }
    }
}
