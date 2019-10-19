using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "stddev")]
    public class StdDev
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
