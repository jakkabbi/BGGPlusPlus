using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "wishing")]
    public class Wishing
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
