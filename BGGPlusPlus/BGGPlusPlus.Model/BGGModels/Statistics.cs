using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "statistics")]
    public class Statistics
    {
        [XmlElement(ElementName = "ratings")]
        public Ratings Ratings { get; set; }
        [XmlAttribute(AttributeName = "page")]
        public string Page { get; set; }
    }

}
