using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class GameMechanic
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int MechanicId { get; set; }

        public virtual Games Game { get; set; }
        public virtual Mechanic Mechanic { get; set; }
    }
}
