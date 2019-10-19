using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "playingtime")]
    public class Playingtime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
