using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "median")]
    public class Median
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
