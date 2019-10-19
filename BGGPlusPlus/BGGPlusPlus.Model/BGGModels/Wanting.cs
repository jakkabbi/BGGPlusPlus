using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "wanting")]
    public class Wanting
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
