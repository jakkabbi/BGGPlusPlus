using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "numweights")]
    public class NumWeights
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
