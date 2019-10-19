using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "minplaytime")]
    public class MinPlaytime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
