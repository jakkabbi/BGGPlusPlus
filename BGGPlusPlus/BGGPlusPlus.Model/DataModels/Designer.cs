using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class Designer
    {
        public Designer()
        {
            GameDesigner = new HashSet<GameDesigner>();
        }

        public int Id { get; set; }
        public string Designer1 { get; set; }

        public virtual ICollection<GameDesigner> GameDesigner { get; set; }
    }
}
