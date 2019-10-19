using System.Xml.Serialization;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "ranks")]
    public class Ranks
    {
        [XmlElement(ElementName = "rank")]
        public List<Rank> Rank { get; set; }
    }

}
