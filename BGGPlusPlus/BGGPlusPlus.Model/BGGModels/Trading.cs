using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "trading")]
    public class Trading
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
