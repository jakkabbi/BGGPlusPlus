using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.Models
{
    public partial class GameCategory
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? CategoryId { get; set; }
    }
}
