using System.Xml.Serialization;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "thumbnail")]
        public string Thumbnail { get; set; }
        [XmlElement(ElementName = "image")]
        public string Image { get; set; }
        [XmlElement(ElementName = "name")]
        public List<Name> Name { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "yearpublished")]
        public Yearpublished Yearpublished { get; set; }
        [XmlElement(ElementName = "minplayers")]
        public MinPlayers Minplayers { get; set; }
        [XmlElement(ElementName = "maxplayers")]
        public MaxPlayers Maxplayers { get; set; }
        [XmlElement(ElementName = "poll")]
        public List<Poll> Poll { get; set; }
        [XmlElement(ElementName = "playingtime")]
        public Playingtime Playingtime { get; set; }
        [XmlElement(ElementName = "minplaytime")]
        public MinPlaytime Minplaytime { get; set; }
        [XmlElement(ElementName = "maxplaytime")]
        public MaxPlaytime Maxplaytime { get; set; }
        [XmlElement(ElementName = "minage")]
        public MinAge Minage { get; set; }
        [XmlElement(ElementName = "link")]
        public List<Link> Link { get; set; }
        [XmlElement(ElementName = "statistics")]
        public Statistics Statistics { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

}
