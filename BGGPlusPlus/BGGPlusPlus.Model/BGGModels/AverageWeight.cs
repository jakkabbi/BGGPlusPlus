using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "averageweight")]
    public class AverageWeight
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
