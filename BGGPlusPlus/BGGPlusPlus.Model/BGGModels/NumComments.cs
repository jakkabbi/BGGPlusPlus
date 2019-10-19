using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "numcomments")]
    public class NumComments
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
