using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "average")]
    public class Average
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
