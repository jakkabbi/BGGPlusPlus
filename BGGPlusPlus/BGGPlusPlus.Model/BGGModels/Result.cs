using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "result")]
    public class Result
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "numvotes")]
        public string Numvotes { get; set; }
        [XmlAttribute(AttributeName = "level")]
        public string Level { get; set; }
    }

}
