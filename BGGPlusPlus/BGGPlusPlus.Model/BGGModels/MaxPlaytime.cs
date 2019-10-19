using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "maxplaytime")]
    public class MaxPlaytime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
