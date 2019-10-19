using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "minage")]
    public class MinAge
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
