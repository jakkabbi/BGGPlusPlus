using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "owned")]
    public class Owned
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
