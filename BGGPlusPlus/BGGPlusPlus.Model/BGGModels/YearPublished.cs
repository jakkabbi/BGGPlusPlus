using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "yearpublished")]
    public class Yearpublished
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }


}
