using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class GameDesigner
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? DesignerId { get; set; }

        public virtual Designer Designer { get; set; }
        public virtual Games Game { get; set; }
    }
}
