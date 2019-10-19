using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "usersrated")]
    public class UsersRated
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
