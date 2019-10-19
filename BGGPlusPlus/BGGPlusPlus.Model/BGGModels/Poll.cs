using System.Xml.Serialization;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "poll")]
    public class Poll
    {
        [XmlElement(ElementName = "results")]
        public List<Results> Results { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "totalvotes")]
        public string Totalvotes { get; set; }
    }

}
