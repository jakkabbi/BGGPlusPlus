using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "minplayers")]
    public class MinPlayers
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
