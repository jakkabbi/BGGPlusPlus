using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class Mechanic
    {
        public Mechanic()
        {
            GameMechanic = new HashSet<GameMechanic>();
        }

        public int Id { get; set; }
        public string Mechanic1 { get; set; }

        public virtual ICollection<GameMechanic> GameMechanic { get; set; }
    }
}
