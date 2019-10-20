using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class Category
    {
        public Category()
        {
            GameCategory = new HashSet<GameCategory>();
        }

        public int Id { get; set; }
        public string Category1 { get; set; }

        public virtual ICollection<GameCategory> GameCategory { get; set; }
    }
}
