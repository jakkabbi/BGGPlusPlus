using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "maxplayers")]
    public class MaxPlayers
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
